using System;
using System.ComponentModel;
using System.Windows.Forms;
//using SolidWorks.Interop.sldworks;
//using SolidWorks.Interop.cosworks;

namespace StatBeamAnalysis
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        //SldWorks swApp;
        double max_tens;
        double min_tens;
        double max_move;
        double min_move;
        double max_deform;
        double min_deform;
        public MainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            bwStudy.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            bwStudy.WorkerSupportsCancellation = true;
            bwStudy.WorkerReportsProgress = true;
            bwStudy.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
        }

        // write only digits
        private void strBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        // progress bar changing
        void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            studyProcess.Value = e.ProgressPercentage;
        }

        // another thread work
        void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            // banning empty fields
            if (string.IsNullOrWhiteSpace(strBox.Text))
            {
                MessageBox.Show("Enter force value", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            processNameLabel.Invoke((MethodInvoker)delegate {
                processNameLabel.Text = "Launching SolidWorks...";
            });

            // check for manual cancelling of analysis
            if (bwStudy.CancellationPending == true)
            {
                processNameLabel.Invoke((MethodInvoker)delegate {
                    processNameLabel.Text = "Analysis has been cancelled";
                });

                e.Cancel = true;
                return;
            }

            // opening SW 2017
            Guid Guid1 = new Guid("6B36082E-677B-49E8-BCB2-76698EBD2906");
            object processSW = System.Activator.CreateInstance(System.Type.GetTypeFromCLSID(Guid1));
            swApp = (SldWorks)processSW;
            swApp.Visible = true;

            processNameLabel.Invoke((MethodInvoker)delegate {
                processNameLabel.Text = "Preparing Simulation...";
            });

            CosmosWorks COSMOSWORKS = default(CosmosWorks);
            CwAddincallback CWAddinCallBack = default(CwAddincallback);
            CWModelDoc ActDoc = default(CWModelDoc);
            CWStudyManager StudyMngr = default(CWStudyManager);
            CWStudy Study = default(CWStudy);
            CWStaticStudyOptions CWOptions = default(CWStaticStudyOptions);
            CWLoadsAndRestraintsManager LBCMgr = default(CWLoadsAndRestraintsManager);
            CWRestraint CWBind = default(CWRestraint);
            CWForce CWStr = default(CWForce);
            CWMesh CWMesh = default(CWMesh);
            CWResults CWResult = default(CWResults);
            CWPlot plot = default(CWPlot);

            ModelDoc2 Part = default(ModelDoc2);
            ModelDoc2 swDoc = null;
            int longstatus = 0;
            int longwarnings = 0;
            int errCode = 0;

            object[] results = null;

            // analysis name
            string study_name = studyNameBox.Text;
            if (string.IsNullOrWhiteSpace(study_name))
            {
                study_name = "Static_beam";
            }

            bwStudy.ReportProgress(5);

            if (bwStudy.CancellationPending == true)
            {
                processNameLabel.Invoke((MethodInvoker)delegate {
                    processNameLabel.Text = "Analysis has been cancelled";
                });

                e.Cancel = true;
                return;
            }

            processNameLabel.Invoke((MethodInvoker)delegate {
                processNameLabel.Text = "Creating beam model...";
            });

            // opening SLDPRT file containing beam model
            Part = swApp.OpenDoc6("C:\\Beam.SLDPRT", 1, 0, "", ref longstatus, ref longwarnings);
            if (Part == null)
            {
                MessageBox.Show("Failed to open model");
                Application.Exit();
            }

            string path_to_cosworks_dll = swApp.GetExecutablePath() + @"\Simulation\cosworks.dll";
            longstatus = swApp.LoadAddIn(path_to_cosworks_dll);

            // isometric view
            swDoc = swApp.IActiveDoc2;
            swDoc.ShowNamedView2("*Isometric", 7);
            swDoc.ViewZoomtofit2();

            bwStudy.ReportProgress(10);

            if (bwStudy.CancellationPending == true)
            {
                processNameLabel.Invoke((MethodInvoker)delegate
                {
                    processNameLabel.Text = "Analysis has been cancelled";
                });

                e.Cancel = true;
                return;
            }

            processNameLabel.Invoke((MethodInvoker)delegate
            {
                processNameLabel.Text = "Starting Simulation...";
            });

            // ready-check Simulation add-on
            CWAddinCallBack = (CwAddincallback)swApp.GetAddInObject("CosmosWorks.CosmosWorks");
            if (CWAddinCallBack == null)
            {
                MessageBox.Show("Failed to start Simulation");
                Application.Exit();
            }

            bwStudy.ReportProgress(12);

            if (bwStudy.CancellationPending == true)
            {
                processNameLabel.Invoke((MethodInvoker)delegate
                {
                    processNameLabel.Text = "Analysis has been cancelled";
                });

                e.Cancel = true;
                return;
            }

            // ready-check add-on object
            COSMOSWORKS = CWAddinCallBack.CosmosWorks;
            if (COSMOSWORKS == null)
            {
                MessageBox.Show("Failed to create CosmosWorks object");
                Application.Exit();
            }

            bwStudy.ReportProgress(14);

            if (bwStudy.CancellationPending == true)
            {
                processNameLabel.Invoke((MethodInvoker)delegate
                {
                    processNameLabel.Text = "Analysis has been cancelled";
                });

                e.Cancel = true;
                return;
            }

            // connecting add-on to document
            ActDoc = COSMOSWORKS.ActiveDoc;
            if (ActDoc == null)
            {
                MessageBox.Show("Failed to connect to document");
                Application.Exit();
            }

            bwStudy.ReportProgress(16);

            if (bwStudy.CancellationPending == true)
            {
                processNameLabel.Invoke((MethodInvoker)delegate
                {
                    processNameLabel.Text = "Analysis has been cancelled";
                });

                e.Cancel = true;
                return;
            }

            processNameLabel.Invoke((MethodInvoker)delegate
            {
                processNameLabel.Text = "Creating analysis...";
            });

            // creating static analysis
            StudyMngr = ActDoc.StudyManager;
            if (StudyMngr == null)
            {
                MessageBox.Show("Failed to start analysis manager");
                Application.Exit();
            }

            bwStudy.ReportProgress(18);

            if (bwStudy.CancellationPending == true)
            {
                processNameLabel.Invoke((MethodInvoker)delegate
                {
                    processNameLabel.Text = "Analysis has been cancelled";
                });

                e.Cancel = true;
                return;
            }

            Study = StudyMngr.CreateNewStudy3(study_name, (int)swsAnalysisStudyType_e.swsAnalysisStudyTypeStatic, (int)swsMeshType_e.swsMeshTypeSolid, out errCode);
            if (Study == null)
            {
                MessageBox.Show("Failed to create static analysis");
                Application.Exit();
            }

            bwStudy.ReportProgress(20);

            if (bwStudy.CancellationPending == true)
            {
                processNameLabel.Invoke((MethodInvoker)delegate
                {
                    processNameLabel.Text = "Analysis has been cancelled";
                });

                e.Cancel = true;
                return;
            }

            processNameLabel.Invoke((MethodInvoker)delegate
            {
                processNameLabel.Text = "Adding attachment object...";
            });

            // loading indicator manager
            LBCMgr = Study.LoadsAndRestraintsManager;
            if (LBCMgr == null)
            {
                MessageBox.Show("Failed to load indicator manager");
                Application.Exit();
            }

            bwStudy.ReportProgress(25);

            if (bwStudy.CancellationPending == true)
            {
                processNameLabel.Invoke((MethodInvoker)delegate
                {
                    processNameLabel.Text = "Analysis has been cancelled";
                });

                e.Cancel = true;
                return;
            }

            // selecting face for attachment and adding it to indicator manager
            ISelectionMgr selectionMgr = (ISelectionMgr)swDoc.SelectionManager;
            bool isSelected = swDoc.Extension.SelectByRay(-0.023870052576342005, 0.064003232713616853, 0, -0.57738154519998108, -0.57728771208554841, -0.57738154519997897, 0.0037366684901689287, 2, true, 0, 0);
            if (isSelected)
            {
                object face_bind = selectionMgr.GetSelectedObject6(1, -1);
                object[] fixedpart = { face_bind };
                CWBind = (CWRestraint)LBCMgr.AddRestraint(0, (fixedpart), null, out errCode);
                if (errCode != 0)
                {
                    MessageBox.Show("Failed to add attachment object");
                    Application.Exit();
                }

            }

            bwStudy.ReportProgress(35);

            if (bwStudy.CancellationPending == true)
            {
                processNameLabel.Invoke((MethodInvoker)delegate
                {
                    processNameLabel.Text = "Analysis has been cancelled";
                });

                e.Cancel = true;
                return;
            }

            processNameLabel.Invoke((MethodInvoker)delegate
            {
                processNameLabel.Text = "Adding force indicator...";
            });

            swDoc.ClearSelection2(true);

            isSelected = swDoc.Extension.SelectByRay(0.00094849719312151137, 0.029999999999915872, 0.97601905600942018, -0.57738154519998108, -0.57728771208554841, -0.57738154519997897, 0.0037366684901689287, 2, true, 0, 0);
            if (isSelected)
            {
                object face_force = selectionMgr.GetSelectedObject6(1, -1);
                object[] fixedpart = { face_force };
                object[] DistanceValues = { };
                object[] ForceValues = { };
                object[] ComponentValues = { };
                CWStr = (CWForce)LBCMgr.AddForce3(1, 0, -1, 0, 0, 0, DistanceValues, ForceValues, false, false, 0, 0, 0, Convert.ToInt32(strBox.Text), ComponentValues, false, false, (fixedpart), null, false, out errCode);
                if (errCode != 0)
                {
                    MessageBox.Show("Failed to add force indicator");
                    Application.Exit();
                }
                CWStr.ForceBeginEdit();
                CWStr.Unit = 2;
                CWStr.ForceEndEdit();
            }

            bwStudy.ReportProgress(50);

            if (bwStudy.CancellationPending == true)
            {
                processNameLabel.Invoke((MethodInvoker)delegate
                {
                    processNameLabel.Text = "Analysis has been cancelled";
                });

                e.Cancel = true;
                return;
            }

            processNameLabel.Invoke((MethodInvoker)delegate
            {
                processNameLabel.Text = "Creating mesh object...";
            });

            swDoc.ClearSelection2(true);

            // mesh object parameters
            CWMesh = ((CWMesh)(Study.Mesh));
            CWMesh.Quality = 1;
            CWMesh.UseJacobianCheckForSolids = 1;
            CWMesh.MesherType = 0;
            CWMesh.AutomaticTransition = 0;
            CWMesh.AutomaticLooping = 0;
            CWMesh.NumberOfLoops = 3;
            CWMesh.SaveSettingsWithoutMeshing = 0;
            CWMesh.Unit = 0;

            bwStudy.ReportProgress(70);

            if (bwStudy.CancellationPending == true)
            {
                processNameLabel.Invoke((MethodInvoker)delegate
                {
                    processNameLabel.Text = "Analysis has been cancelled";
                });

                e.Cancel = true;
                return;
            }

            // creating mesh object
            errCode = Study.CreateMesh(0, 13.3821, 0.669103);
            if (errCode != 0)
            {
                MessageBox.Show("Failed to create mesh object");
                Application.Exit();
            }

            processNameLabel.Invoke((MethodInvoker)delegate
            {
                processNameLabel.Text = "Starting analysis...";
            });

            // starting analysis
            errCode = Study.RunAnalysis();
            if (errCode != 0)
            {
                MessageBox.Show("Failed to start analysis");
                Application.Exit();
            }

            bwStudy.ReportProgress(90);

            if (bwStudy.CancellationPending == true)
            {
                processNameLabel.Invoke((MethodInvoker)delegate
                {
                    processNameLabel.Text = "Analysis has been cancelled";
                });

                e.Cancel = true;
                return;
            }

            processNameLabel.Invoke((MethodInvoker)delegate
            {
                processNameLabel.Text = "Receiving analysis results...";
            });

            // obtaining results
            CWResult = (CWResults)Study.Results;
            if (CWResult == null)
            {
                MessageBox.Show("Failed to receive results");
                return;
            }

            // stress graph results
            plot = CWResult.GetPlot("Stress1", out errCode);
            if (plot == null)
            {
                MessageBox.Show("Failed to receive stress results");
                return;
            }
            plot.SetComponentUnitAndValueByElem(9, 3, false);
            results = (object[])plot.GetMinMaxResultValues(out errCode);

            max_tens = Convert.ToDouble(results[3].ToString());
            min_tens = Convert.ToDouble(results[1].ToString());

            bwStudy.ReportProgress(93);

            if (bwStudy.CancellationPending == true)
            {
                processNameLabel.Invoke((MethodInvoker)delegate
                {
                    processNameLabel.Text = "Analysis has been cancelled";
                });

                e.Cancel = true;
                return;
            }

            // displacement graph results
            plot = CWResult.GetPlot("Displacement1", out errCode);
            if (plot == null)
            {
                MessageBox.Show("Failed to receive displacement results");
                return;
            }
            plot.SetComponentUnitAndValueByElem(3, 0, false);
            results = (object[])plot.GetMinMaxResultValues(out errCode);

            max_move = Convert.ToDouble(results[3].ToString());
            min_move = Convert.ToDouble(results[1].ToString());

            bwStudy.ReportProgress(96);

            if (bwStudy.CancellationPending == true)
            {
                processNameLabel.Invoke((MethodInvoker)delegate
                {
                    processNameLabel.Text = "Analysis has been cancelled";
                });

                e.Cancel = true;
                return;
            }

            // strain graph results
            plot = CWResult.GetPlot("Strain1", out errCode);
            if (plot == null)
            {
                MessageBox.Show("Failed to receive strain results");
                return;
            }
            plot.SetComponentUnitAndValueByElem(6, 3, false);
            results = (object[])plot.GetMinMaxResultValues(out errCode);

            bwStudy.ReportProgress(99);

            max_deform = Convert.ToDouble(results[3].ToString());
            min_deform = Convert.ToDouble(results[1].ToString());

            maxTensBox.Invoke((MethodInvoker)delegate
            {
                maxTensBox.Text = max_tens.ToString();
            });

            minTensBox.Invoke((MethodInvoker)delegate
            {
                minTensBox.Text = min_tens.ToString();
            });

            maxMoveBox.Invoke((MethodInvoker)delegate
            {
                maxMoveBox.Text = max_move.ToString();
            });

            minMoveBox.Invoke((MethodInvoker)delegate
            {
                minMoveBox.Text = min_move.ToString();
            });

            maxDeformBox.Invoke((MethodInvoker)delegate
            {
                maxDeformBox.Text = max_deform.ToString();
            });

            minDeformBox.Invoke((MethodInvoker)delegate
            {
                minDeformBox.Text = min_deform.ToString();
            });

            bwStudy.ReportProgress(100);

            processNameLabel.Invoke((MethodInvoker)delegate
            {
                processNameLabel.Text = "Done";
            });
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (!bwStudy.IsBusy)
            {
                bwStudy.RunWorkerAsync();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            bwStudy.CancelAsync();
        }
    }
}
