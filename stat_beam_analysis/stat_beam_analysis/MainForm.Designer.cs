namespace StatBeamAnalysis
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.strBox = new MetroFramework.Controls.MetroTextBox();
            this.strCULabel = new MetroFramework.Controls.MetroLabel();
            this.strLabel = new MetroFramework.Controls.MetroLabel();
            this.matLabel = new MetroFramework.Controls.MetroLabel();
            this.matBox = new MetroFramework.Controls.MetroTextBox();
            this.resPanel = new MetroFramework.Controls.MetroPanel();
            this.deformCULabel2 = new MetroFramework.Controls.MetroLabel();
            this.deformCULabel = new MetroFramework.Controls.MetroLabel();
            this.maxDeformLabel = new MetroFramework.Controls.MetroLabel();
            this.maxDeformBox = new MetroFramework.Controls.MetroTextBox();
            this.minDeformLabel = new MetroFramework.Controls.MetroLabel();
            this.minDeformBox = new MetroFramework.Controls.MetroTextBox();
            this.moveCULabel2 = new MetroFramework.Controls.MetroLabel();
            this.maxMoveLabel = new MetroFramework.Controls.MetroLabel();
            this.maxMoveBox = new MetroFramework.Controls.MetroTextBox();
            this.moveCULabel = new MetroFramework.Controls.MetroLabel();
            this.minMoveLabel = new MetroFramework.Controls.MetroLabel();
            this.minMoveBox = new MetroFramework.Controls.MetroTextBox();
            this.tensCULabel2 = new MetroFramework.Controls.MetroLabel();
            this.maxTensLabel = new MetroFramework.Controls.MetroLabel();
            this.maxTensBox = new MetroFramework.Controls.MetroTextBox();
            this.tensCULabel = new MetroFramework.Controls.MetroLabel();
            this.minTensLabel = new MetroFramework.Controls.MetroLabel();
            this.minTensBox = new MetroFramework.Controls.MetroTextBox();
            this.deformLabel = new MetroFramework.Controls.MetroLabel();
            this.moveLabel = new MetroFramework.Controls.MetroLabel();
            this.tensLabel = new MetroFramework.Controls.MetroLabel();
            this.resLabel = new MetroFramework.Controls.MetroLabel();
            this.startButton = new MetroFramework.Controls.MetroButton();
            this.studyNameLabel = new MetroFramework.Controls.MetroLabel();
            this.studyNameBox = new MetroFramework.Controls.MetroTextBox();
            this.studyProcess = new MetroFramework.Controls.MetroProgressBar();
            this.stageProcessLabel = new MetroFramework.Controls.MetroLabel();
            this.bwStudy = new System.ComponentModel.BackgroundWorker();
            this.cancelButton = new MetroFramework.Controls.MetroButton();
            this.processNameLabel = new MetroFramework.Controls.MetroLabel();
            this.authorLabel = new MetroFramework.Controls.MetroLabel();
            this.resPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // strBox
            // 
            // 
            // 
            // 
            this.strBox.CustomButton.Image = null;
            this.strBox.CustomButton.Location = new System.Drawing.Point(38, 1);
            this.strBox.CustomButton.Name = "";
            this.strBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.strBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.strBox.CustomButton.TabIndex = 1;
            this.strBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.strBox.CustomButton.UseSelectable = true;
            this.strBox.CustomButton.Visible = false;
            this.strBox.Lines = new string[0];
            this.strBox.Location = new System.Drawing.Point(245, 155);
            this.strBox.MaxLength = 32767;
            this.strBox.Name = "strBox";
            this.strBox.PasswordChar = '\0';
            this.strBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.strBox.SelectedText = "";
            this.strBox.SelectionLength = 0;
            this.strBox.SelectionStart = 0;
            this.strBox.ShortcutsEnabled = true;
            this.strBox.Size = new System.Drawing.Size(60, 23);
            this.strBox.TabIndex = 0;
            this.strBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.strBox.UseSelectable = true;
            this.strBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.strBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.strBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.strBox_KeyPress);
            // 
            // strCULabel
            // 
            this.strCULabel.AutoSize = true;
            this.strCULabel.Location = new System.Drawing.Point(308, 155);
            this.strCULabel.Name = "strCULabel";
            this.strCULabel.Size = new System.Drawing.Size(27, 19);
            this.strCULabel.TabIndex = 1;
            this.strCULabel.Text = "kgf";
            this.strCULabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // strLabel
            // 
            this.strLabel.AutoSize = true;
            this.strLabel.Location = new System.Drawing.Point(23, 155);
            this.strLabel.Name = "strLabel";
            this.strLabel.Size = new System.Drawing.Size(184, 19);
            this.strLabel.TabIndex = 2;
            this.strLabel.Text = "Force at the end of the beam:";
            this.strLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // matLabel
            // 
            this.matLabel.AutoSize = true;
            this.matLabel.Location = new System.Drawing.Point(23, 91);
            this.matLabel.Name = "matLabel";
            this.matLabel.Size = new System.Drawing.Size(98, 19);
            this.matLabel.TabIndex = 5;
            this.matLabel.Text = "Beam material:";
            this.matLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // matBox
            // 
            this.matBox.BackColor = System.Drawing.Color.Salmon;
            // 
            // 
            // 
            this.matBox.CustomButton.Image = null;
            this.matBox.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.matBox.CustomButton.Name = "";
            this.matBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.matBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.matBox.CustomButton.TabIndex = 1;
            this.matBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.matBox.CustomButton.UseSelectable = true;
            this.matBox.CustomButton.Visible = false;
            this.matBox.ForeColor = System.Drawing.Color.Orange;
            this.matBox.Lines = new string[] {
        "Carbon steel"};
            this.matBox.Location = new System.Drawing.Point(245, 91);
            this.matBox.MaxLength = 32767;
            this.matBox.Name = "matBox";
            this.matBox.PasswordChar = '\0';
            this.matBox.ReadOnly = true;
            this.matBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.matBox.SelectedText = "";
            this.matBox.SelectionLength = 0;
            this.matBox.SelectionStart = 0;
            this.matBox.ShortcutsEnabled = true;
            this.matBox.Size = new System.Drawing.Size(140, 23);
            this.matBox.Style = MetroFramework.MetroColorStyle.Orange;
            this.matBox.TabIndex = 3;
            this.matBox.Text = "Carbon steel";
            this.matBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.matBox.UseCustomForeColor = true;
            this.matBox.UseSelectable = true;
            this.matBox.UseStyleColors = true;
            this.matBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.matBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // resPanel
            // 
            this.resPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resPanel.Controls.Add(this.deformCULabel2);
            this.resPanel.Controls.Add(this.deformCULabel);
            this.resPanel.Controls.Add(this.maxDeformLabel);
            this.resPanel.Controls.Add(this.maxDeformBox);
            this.resPanel.Controls.Add(this.minDeformLabel);
            this.resPanel.Controls.Add(this.minDeformBox);
            this.resPanel.Controls.Add(this.moveCULabel2);
            this.resPanel.Controls.Add(this.maxMoveLabel);
            this.resPanel.Controls.Add(this.maxMoveBox);
            this.resPanel.Controls.Add(this.moveCULabel);
            this.resPanel.Controls.Add(this.minMoveLabel);
            this.resPanel.Controls.Add(this.minMoveBox);
            this.resPanel.Controls.Add(this.tensCULabel2);
            this.resPanel.Controls.Add(this.maxTensLabel);
            this.resPanel.Controls.Add(this.maxTensBox);
            this.resPanel.Controls.Add(this.tensCULabel);
            this.resPanel.Controls.Add(this.minTensLabel);
            this.resPanel.Controls.Add(this.minTensBox);
            this.resPanel.Controls.Add(this.deformLabel);
            this.resPanel.Controls.Add(this.moveLabel);
            this.resPanel.Controls.Add(this.tensLabel);
            this.resPanel.Controls.Add(this.resLabel);
            this.resPanel.HorizontalScrollbarBarColor = true;
            this.resPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.resPanel.HorizontalScrollbarSize = 10;
            this.resPanel.Location = new System.Drawing.Point(410, 38);
            this.resPanel.Name = "resPanel";
            this.resPanel.Size = new System.Drawing.Size(372, 259);
            this.resPanel.TabIndex = 6;
            this.resPanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.resPanel.VerticalScrollbarBarColor = true;
            this.resPanel.VerticalScrollbarHighlightOnWheel = false;
            this.resPanel.VerticalScrollbarSize = 10;
            // 
            // deformCULabel2
            // 
            this.deformCULabel2.AutoSize = true;
            this.deformCULabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.deformCULabel2.Location = new System.Drawing.Point(333, 216);
            this.deformCULabel2.Name = "deformCULabel2";
            this.deformCULabel2.Size = new System.Drawing.Size(29, 15);
            this.deformCULabel2.TabIndex = 30;
            this.deformCULabel2.Text = "MPa";
            this.deformCULabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // deformCULabel
            // 
            this.deformCULabel.AutoSize = true;
            this.deformCULabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.deformCULabel.Location = new System.Drawing.Point(140, 216);
            this.deformCULabel.Name = "deformCULabel";
            this.deformCULabel.Size = new System.Drawing.Size(29, 15);
            this.deformCULabel.TabIndex = 29;
            this.deformCULabel.Text = "MPa";
            this.deformCULabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // maxDeformLabel
            // 
            this.maxDeformLabel.AutoSize = true;
            this.maxDeformLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.maxDeformLabel.Location = new System.Drawing.Point(203, 216);
            this.maxDeformLabel.Name = "maxDeformLabel";
            this.maxDeformLabel.Size = new System.Drawing.Size(31, 15);
            this.maxDeformLabel.TabIndex = 28;
            this.maxDeformLabel.Text = "Max:";
            this.maxDeformLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // maxDeformBox
            // 
            // 
            // 
            // 
            this.maxDeformBox.CustomButton.Image = null;
            this.maxDeformBox.CustomButton.Location = new System.Drawing.Point(64, 1);
            this.maxDeformBox.CustomButton.Name = "";
            this.maxDeformBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.maxDeformBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.maxDeformBox.CustomButton.TabIndex = 1;
            this.maxDeformBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.maxDeformBox.CustomButton.UseSelectable = true;
            this.maxDeformBox.CustomButton.Visible = false;
            this.maxDeformBox.Lines = new string[0];
            this.maxDeformBox.Location = new System.Drawing.Point(240, 213);
            this.maxDeformBox.MaxLength = 32767;
            this.maxDeformBox.Name = "maxDeformBox";
            this.maxDeformBox.PasswordChar = '\0';
            this.maxDeformBox.ReadOnly = true;
            this.maxDeformBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.maxDeformBox.SelectedText = "";
            this.maxDeformBox.SelectionLength = 0;
            this.maxDeformBox.SelectionStart = 0;
            this.maxDeformBox.ShortcutsEnabled = true;
            this.maxDeformBox.Size = new System.Drawing.Size(86, 23);
            this.maxDeformBox.TabIndex = 27;
            this.maxDeformBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.maxDeformBox.UseSelectable = true;
            this.maxDeformBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.maxDeformBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // minDeformLabel
            // 
            this.minDeformLabel.AutoSize = true;
            this.minDeformLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.minDeformLabel.Location = new System.Drawing.Point(6, 216);
            this.minDeformLabel.Name = "minDeformLabel";
            this.minDeformLabel.Size = new System.Drawing.Size(28, 15);
            this.minDeformLabel.TabIndex = 25;
            this.minDeformLabel.Text = "Min:";
            this.minDeformLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // minDeformBox
            // 
            // 
            // 
            // 
            this.minDeformBox.CustomButton.Image = null;
            this.minDeformBox.CustomButton.Location = new System.Drawing.Point(64, 1);
            this.minDeformBox.CustomButton.Name = "";
            this.minDeformBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.minDeformBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.minDeformBox.CustomButton.TabIndex = 1;
            this.minDeformBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.minDeformBox.CustomButton.UseSelectable = true;
            this.minDeformBox.CustomButton.Visible = false;
            this.minDeformBox.Lines = new string[0];
            this.minDeformBox.Location = new System.Drawing.Point(44, 213);
            this.minDeformBox.MaxLength = 32767;
            this.minDeformBox.Name = "minDeformBox";
            this.minDeformBox.PasswordChar = '\0';
            this.minDeformBox.ReadOnly = true;
            this.minDeformBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.minDeformBox.SelectedText = "";
            this.minDeformBox.SelectionLength = 0;
            this.minDeformBox.SelectionStart = 0;
            this.minDeformBox.ShortcutsEnabled = true;
            this.minDeformBox.Size = new System.Drawing.Size(86, 23);
            this.minDeformBox.TabIndex = 24;
            this.minDeformBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.minDeformBox.UseSelectable = true;
            this.minDeformBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.minDeformBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // moveCULabel2
            // 
            this.moveCULabel2.AutoSize = true;
            this.moveCULabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.moveCULabel2.Location = new System.Drawing.Point(333, 140);
            this.moveCULabel2.Name = "moveCULabel2";
            this.moveCULabel2.Size = new System.Drawing.Size(27, 15);
            this.moveCULabel2.TabIndex = 23;
            this.moveCULabel2.Text = "mm";
            this.moveCULabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // maxMoveLabel
            // 
            this.maxMoveLabel.AutoSize = true;
            this.maxMoveLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.maxMoveLabel.Location = new System.Drawing.Point(203, 140);
            this.maxMoveLabel.Name = "maxMoveLabel";
            this.maxMoveLabel.Size = new System.Drawing.Size(31, 15);
            this.maxMoveLabel.TabIndex = 22;
            this.maxMoveLabel.Text = "Max:";
            this.maxMoveLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // maxMoveBox
            // 
            // 
            // 
            // 
            this.maxMoveBox.CustomButton.Image = null;
            this.maxMoveBox.CustomButton.Location = new System.Drawing.Point(63, 1);
            this.maxMoveBox.CustomButton.Name = "";
            this.maxMoveBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.maxMoveBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.maxMoveBox.CustomButton.TabIndex = 1;
            this.maxMoveBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.maxMoveBox.CustomButton.UseSelectable = true;
            this.maxMoveBox.CustomButton.Visible = false;
            this.maxMoveBox.Lines = new string[0];
            this.maxMoveBox.Location = new System.Drawing.Point(241, 137);
            this.maxMoveBox.MaxLength = 32767;
            this.maxMoveBox.Name = "maxMoveBox";
            this.maxMoveBox.PasswordChar = '\0';
            this.maxMoveBox.ReadOnly = true;
            this.maxMoveBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.maxMoveBox.SelectedText = "";
            this.maxMoveBox.SelectionLength = 0;
            this.maxMoveBox.SelectionStart = 0;
            this.maxMoveBox.ShortcutsEnabled = true;
            this.maxMoveBox.Size = new System.Drawing.Size(85, 23);
            this.maxMoveBox.TabIndex = 21;
            this.maxMoveBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.maxMoveBox.UseSelectable = true;
            this.maxMoveBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.maxMoveBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // moveCULabel
            // 
            this.moveCULabel.AutoSize = true;
            this.moveCULabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.moveCULabel.Location = new System.Drawing.Point(140, 140);
            this.moveCULabel.Name = "moveCULabel";
            this.moveCULabel.Size = new System.Drawing.Size(27, 15);
            this.moveCULabel.TabIndex = 20;
            this.moveCULabel.Text = "mm";
            this.moveCULabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // minMoveLabel
            // 
            this.minMoveLabel.AutoSize = true;
            this.minMoveLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.minMoveLabel.Location = new System.Drawing.Point(6, 140);
            this.minMoveLabel.Name = "minMoveLabel";
            this.minMoveLabel.Size = new System.Drawing.Size(28, 15);
            this.minMoveLabel.TabIndex = 19;
            this.minMoveLabel.Text = "Min:";
            this.minMoveLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // minMoveBox
            // 
            // 
            // 
            // 
            this.minMoveBox.CustomButton.Image = null;
            this.minMoveBox.CustomButton.Location = new System.Drawing.Point(64, 1);
            this.minMoveBox.CustomButton.Name = "";
            this.minMoveBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.minMoveBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.minMoveBox.CustomButton.TabIndex = 1;
            this.minMoveBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.minMoveBox.CustomButton.UseSelectable = true;
            this.minMoveBox.CustomButton.Visible = false;
            this.minMoveBox.Lines = new string[0];
            this.minMoveBox.Location = new System.Drawing.Point(44, 137);
            this.minMoveBox.MaxLength = 32767;
            this.minMoveBox.Name = "minMoveBox";
            this.minMoveBox.PasswordChar = '\0';
            this.minMoveBox.ReadOnly = true;
            this.minMoveBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.minMoveBox.SelectedText = "";
            this.minMoveBox.SelectionLength = 0;
            this.minMoveBox.SelectionStart = 0;
            this.minMoveBox.ShortcutsEnabled = true;
            this.minMoveBox.Size = new System.Drawing.Size(86, 23);
            this.minMoveBox.TabIndex = 18;
            this.minMoveBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.minMoveBox.UseSelectable = true;
            this.minMoveBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.minMoveBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tensCULabel2
            // 
            this.tensCULabel2.AutoSize = true;
            this.tensCULabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.tensCULabel2.Location = new System.Drawing.Point(333, 68);
            this.tensCULabel2.Name = "tensCULabel2";
            this.tensCULabel2.Size = new System.Drawing.Size(29, 15);
            this.tensCULabel2.TabIndex = 17;
            this.tensCULabel2.Text = "MPa";
            this.tensCULabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // maxTensLabel
            // 
            this.maxTensLabel.AutoSize = true;
            this.maxTensLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.maxTensLabel.Location = new System.Drawing.Point(203, 68);
            this.maxTensLabel.Name = "maxTensLabel";
            this.maxTensLabel.Size = new System.Drawing.Size(31, 15);
            this.maxTensLabel.TabIndex = 16;
            this.maxTensLabel.Text = "Max:";
            this.maxTensLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // maxTensBox
            // 
            // 
            // 
            // 
            this.maxTensBox.CustomButton.Image = null;
            this.maxTensBox.CustomButton.Location = new System.Drawing.Point(63, 1);
            this.maxTensBox.CustomButton.Name = "";
            this.maxTensBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.maxTensBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.maxTensBox.CustomButton.TabIndex = 1;
            this.maxTensBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.maxTensBox.CustomButton.UseSelectable = true;
            this.maxTensBox.CustomButton.Visible = false;
            this.maxTensBox.Lines = new string[0];
            this.maxTensBox.Location = new System.Drawing.Point(241, 65);
            this.maxTensBox.MaxLength = 32767;
            this.maxTensBox.Name = "maxTensBox";
            this.maxTensBox.PasswordChar = '\0';
            this.maxTensBox.ReadOnly = true;
            this.maxTensBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.maxTensBox.SelectedText = "";
            this.maxTensBox.SelectionLength = 0;
            this.maxTensBox.SelectionStart = 0;
            this.maxTensBox.ShortcutsEnabled = true;
            this.maxTensBox.Size = new System.Drawing.Size(85, 23);
            this.maxTensBox.TabIndex = 15;
            this.maxTensBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.maxTensBox.UseSelectable = true;
            this.maxTensBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.maxTensBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tensCULabel
            // 
            this.tensCULabel.AutoSize = true;
            this.tensCULabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.tensCULabel.Location = new System.Drawing.Point(140, 68);
            this.tensCULabel.Name = "tensCULabel";
            this.tensCULabel.Size = new System.Drawing.Size(29, 15);
            this.tensCULabel.TabIndex = 14;
            this.tensCULabel.Text = "MPa";
            this.tensCULabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // minTensLabel
            // 
            this.minTensLabel.AutoSize = true;
            this.minTensLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.minTensLabel.Location = new System.Drawing.Point(6, 68);
            this.minTensLabel.Name = "minTensLabel";
            this.minTensLabel.Size = new System.Drawing.Size(28, 15);
            this.minTensLabel.TabIndex = 11;
            this.minTensLabel.Text = "Min:";
            this.minTensLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // minTensBox
            // 
            // 
            // 
            // 
            this.minTensBox.CustomButton.Image = null;
            this.minTensBox.CustomButton.Location = new System.Drawing.Point(64, 1);
            this.minTensBox.CustomButton.Name = "";
            this.minTensBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.minTensBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.minTensBox.CustomButton.TabIndex = 1;
            this.minTensBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.minTensBox.CustomButton.UseSelectable = true;
            this.minTensBox.CustomButton.Visible = false;
            this.minTensBox.Lines = new string[0];
            this.minTensBox.Location = new System.Drawing.Point(44, 65);
            this.minTensBox.MaxLength = 32767;
            this.minTensBox.Name = "minTensBox";
            this.minTensBox.PasswordChar = '\0';
            this.minTensBox.ReadOnly = true;
            this.minTensBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.minTensBox.SelectedText = "";
            this.minTensBox.SelectionLength = 0;
            this.minTensBox.SelectionStart = 0;
            this.minTensBox.ShortcutsEnabled = true;
            this.minTensBox.Size = new System.Drawing.Size(86, 23);
            this.minTensBox.TabIndex = 7;
            this.minTensBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.minTensBox.UseSelectable = true;
            this.minTensBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.minTensBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // deformLabel
            // 
            this.deformLabel.AutoSize = true;
            this.deformLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.deformLabel.Location = new System.Drawing.Point(4, 190);
            this.deformLabel.Name = "deformLabel";
            this.deformLabel.Size = new System.Drawing.Size(170, 19);
            this.deformLabel.TabIndex = 10;
            this.deformLabel.Text = "Equivalent deformation:";
            this.deformLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // moveLabel
            // 
            this.moveLabel.AutoSize = true;
            this.moveLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.moveLabel.Location = new System.Drawing.Point(4, 112);
            this.moveLabel.Name = "moveLabel";
            this.moveLabel.Size = new System.Drawing.Size(103, 19);
            this.moveLabel.TabIndex = 9;
            this.moveLabel.Text = "Displacement:";
            this.moveLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tensLabel
            // 
            this.tensLabel.AutoSize = true;
            this.tensLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.tensLabel.Location = new System.Drawing.Point(4, 41);
            this.tensLabel.Name = "tensLabel";
            this.tensLabel.Size = new System.Drawing.Size(63, 19);
            this.tensLabel.TabIndex = 8;
            this.tensLabel.Text = "Tension:";
            this.tensLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // resLabel
            // 
            this.resLabel.AutoSize = true;
            this.resLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.resLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.resLabel.Location = new System.Drawing.Point(3, 2);
            this.resLabel.Name = "resLabel";
            this.resLabel.Size = new System.Drawing.Size(71, 25);
            this.resLabel.TabIndex = 7;
            this.resLabel.Text = "Results:";
            this.resLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(23, 198);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(132, 42);
            this.startButton.Style = MetroFramework.MetroColorStyle.Orange;
            this.startButton.TabIndex = 7;
            this.startButton.Text = "Start analysis";
            this.startButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.startButton.UseSelectable = true;
            this.startButton.UseStyleColors = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // studyNameLabel
            // 
            this.studyNameLabel.AutoSize = true;
            this.studyNameLabel.Location = new System.Drawing.Point(23, 123);
            this.studyNameLabel.Name = "studyNameLabel";
            this.studyNameLabel.Size = new System.Drawing.Size(94, 19);
            this.studyNameLabel.TabIndex = 9;
            this.studyNameLabel.Text = "Analysis name:";
            this.studyNameLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // studyNameBox
            // 
            this.studyNameBox.BackColor = System.Drawing.Color.Salmon;
            // 
            // 
            // 
            this.studyNameBox.CustomButton.Image = null;
            this.studyNameBox.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.studyNameBox.CustomButton.Name = "";
            this.studyNameBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.studyNameBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.studyNameBox.CustomButton.TabIndex = 1;
            this.studyNameBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.studyNameBox.CustomButton.UseSelectable = true;
            this.studyNameBox.CustomButton.Visible = false;
            this.studyNameBox.ForeColor = System.Drawing.Color.Orange;
            this.studyNameBox.Lines = new string[] {
        "Static_beam"};
            this.studyNameBox.Location = new System.Drawing.Point(245, 123);
            this.studyNameBox.MaxLength = 32767;
            this.studyNameBox.Name = "studyNameBox";
            this.studyNameBox.PasswordChar = '\0';
            this.studyNameBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.studyNameBox.SelectedText = "";
            this.studyNameBox.SelectionLength = 0;
            this.studyNameBox.SelectionStart = 0;
            this.studyNameBox.ShortcutsEnabled = true;
            this.studyNameBox.Size = new System.Drawing.Size(140, 23);
            this.studyNameBox.TabIndex = 8;
            this.studyNameBox.Text = "Static_beam";
            this.studyNameBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.studyNameBox.UseSelectable = true;
            this.studyNameBox.UseStyleColors = true;
            this.studyNameBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.studyNameBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // studyProcess
            // 
            this.studyProcess.Location = new System.Drawing.Point(23, 252);
            this.studyProcess.Name = "studyProcess";
            this.studyProcess.Size = new System.Drawing.Size(362, 23);
            this.studyProcess.Style = MetroFramework.MetroColorStyle.Orange;
            this.studyProcess.TabIndex = 10;
            this.studyProcess.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // stageProcessLabel
            // 
            this.stageProcessLabel.AutoSize = true;
            this.stageProcessLabel.Location = new System.Drawing.Point(19, 278);
            this.stageProcessLabel.Name = "stageProcessLabel";
            this.stageProcessLabel.Size = new System.Drawing.Size(93, 19);
            this.stageProcessLabel.TabIndex = 11;
            this.stageProcessLabel.Text = "Analysis status:";
            this.stageProcessLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // cancelButton
            // 
            this.cancelButton.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.cancelButton.Location = new System.Drawing.Point(253, 198);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(132, 42);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Cancel analysis";
            this.cancelButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cancelButton.UseCustomForeColor = true;
            this.cancelButton.UseSelectable = true;
            this.cancelButton.UseStyleColors = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // processNameLabel
            // 
            this.processNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.processNameLabel.Location = new System.Drawing.Point(118, 278);
            this.processNameLabel.Name = "processNameLabel";
            this.processNameLabel.Size = new System.Drawing.Size(263, 19);
            this.processNameLabel.Style = MetroFramework.MetroColorStyle.Orange;
            this.processNameLabel.TabIndex = 13;
            this.processNameLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.processNameLabel.UseStyleColors = true;
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.authorLabel.Location = new System.Drawing.Point(23, 47);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(0, 0);
            this.authorLabel.Style = MetroFramework.MetroColorStyle.Silver;
            this.authorLabel.TabIndex = 14;
            this.authorLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.authorLabel.UseStyleColors = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 332);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.processNameLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.stageProcessLabel);
            this.Controls.Add(this.studyProcess);
            this.Controls.Add(this.studyNameLabel);
            this.Controls.Add(this.studyNameBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.resPanel);
            this.Controls.Add(this.matLabel);
            this.Controls.Add(this.matBox);
            this.Controls.Add(this.strLabel);
            this.Controls.Add(this.strCULabel);
            this.Controls.Add(this.strBox);
            this.Name = "MainForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Static beam analysis";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.resPanel.ResumeLayout(false);
            this.resPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox strBox;
        private MetroFramework.Controls.MetroLabel strCULabel;
        private MetroFramework.Controls.MetroLabel strLabel;
        private MetroFramework.Controls.MetroLabel matLabel;
        private MetroFramework.Controls.MetroTextBox matBox;
        private MetroFramework.Controls.MetroPanel resPanel;
        private MetroFramework.Controls.MetroLabel resLabel;
        private MetroFramework.Controls.MetroLabel minTensLabel;
        private MetroFramework.Controls.MetroTextBox minTensBox;
        private MetroFramework.Controls.MetroLabel deformLabel;
        private MetroFramework.Controls.MetroLabel moveLabel;
        private MetroFramework.Controls.MetroLabel tensLabel;
        private MetroFramework.Controls.MetroLabel tensCULabel;
        private MetroFramework.Controls.MetroButton startButton;
        private MetroFramework.Controls.MetroLabel maxDeformLabel;
        private MetroFramework.Controls.MetroTextBox maxDeformBox;
        private MetroFramework.Controls.MetroLabel minDeformLabel;
        private MetroFramework.Controls.MetroTextBox minDeformBox;
        private MetroFramework.Controls.MetroLabel moveCULabel2;
        private MetroFramework.Controls.MetroLabel maxMoveLabel;
        private MetroFramework.Controls.MetroTextBox maxMoveBox;
        private MetroFramework.Controls.MetroLabel moveCULabel;
        private MetroFramework.Controls.MetroLabel minMoveLabel;
        private MetroFramework.Controls.MetroTextBox minMoveBox;
        private MetroFramework.Controls.MetroLabel tensCULabel2;
        private MetroFramework.Controls.MetroLabel maxTensLabel;
        private MetroFramework.Controls.MetroTextBox maxTensBox;
        private MetroFramework.Controls.MetroLabel deformCULabel2;
        private MetroFramework.Controls.MetroLabel deformCULabel;
        private MetroFramework.Controls.MetroLabel studyNameLabel;
        private MetroFramework.Controls.MetroTextBox studyNameBox;
        private MetroFramework.Controls.MetroProgressBar studyProcess;
        private MetroFramework.Controls.MetroLabel stageProcessLabel;
        private System.ComponentModel.BackgroundWorker bwStudy;
        private MetroFramework.Controls.MetroButton cancelButton;
        private MetroFramework.Controls.MetroLabel processNameLabel;
        private MetroFramework.Controls.MetroLabel authorLabel;
    }
}

