namespace AlgoProject_SoundsPacking_
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.controlLbl = new System.Windows.Forms.Label();
            this.miniBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.inputDataGroup = new System.Windows.Forms.GroupBox();
            this.textBtn = new System.Windows.Forms.Button();
            this.audiosBtn = new System.Windows.Forms.Button();
            this.textTxt = new System.Windows.Forms.TextBox();
            this.audiosTxt = new System.Windows.Forms.TextBox();
            this.audiosFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.textFileBrowser = new System.Windows.Forms.OpenFileDialog();
            this.outputDataGroup = new System.Windows.Forms.GroupBox();
            this.timerPerFolderLbl = new System.Windows.Forms.Label();
            this.timePerFolderTxt = new System.Windows.Forms.MaskedTextBox();
            this.secPerFolderLbl = new System.Windows.Forms.Label();
            this.secLbl = new System.Windows.Forms.Label();
            this.audiosOutBtn = new System.Windows.Forms.Button();
            this.audiosOutTxt = new System.Windows.Forms.TextBox();
            this.generateAudios = new System.Windows.Forms.Button();
            this.timersGroup = new System.Windows.Forms.GroupBox();
            this.ff = new System.Windows.Forms.Label();
            this.ffdls = new System.Windows.Forms.Label();
            this.wfdpq = new System.Windows.Forms.Label();
            this.wfdls = new System.Windows.Forms.Label();
            this.wfpq = new System.Windows.Forms.Label();
            this.wfls = new System.Windows.Forms.Label();
            this.FFLbl = new System.Windows.Forms.Label();
            this.FFDLSLbl = new System.Windows.Forms.Label();
            this.WFDPQLbl = new System.Windows.Forms.Label();
            this.WFDLSLbl = new System.Windows.Forms.Label();
            this.WFPQLbl = new System.Windows.Forms.Label();
            this.WFLSLbl = new System.Windows.Forms.Label();
            this.genTimer = new System.Windows.Forms.Timer(this.components);
            this.controlPanel.SuspendLayout();
            this.inputDataGroup.SuspendLayout();
            this.outputDataGroup.SuspendLayout();
            this.timersGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.Transparent;
            this.controlPanel.Controls.Add(this.controlLbl);
            this.controlPanel.Controls.Add(this.miniBtn);
            this.controlPanel.Controls.Add(this.closeBtn);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlPanel.Location = new System.Drawing.Point(0, 0);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(626, 41);
            this.controlPanel.TabIndex = 1;
            // 
            // controlLbl
            // 
            this.controlLbl.BackColor = System.Drawing.Color.Transparent;
            this.controlLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlLbl.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlLbl.ForeColor = System.Drawing.Color.Firebrick;
            this.controlLbl.Location = new System.Drawing.Point(0, 0);
            this.controlLbl.Name = "controlLbl";
            this.controlLbl.Size = new System.Drawing.Size(546, 41);
            this.controlLbl.TabIndex = 3;
            this.controlLbl.Text = "Sounds Packing";
            this.controlLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.controlLbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.controlLbl_MouseDown);
            this.controlLbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlLbl_MouseMove);
            // 
            // miniBtn
            // 
            this.miniBtn.BackColor = System.Drawing.Color.Transparent;
            this.miniBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.miniBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.miniBtn.FlatAppearance.BorderSize = 0;
            this.miniBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.miniBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miniBtn.ForeColor = System.Drawing.Color.DimGray;
            this.miniBtn.Location = new System.Drawing.Point(546, 0);
            this.miniBtn.Name = "miniBtn";
            this.miniBtn.Size = new System.Drawing.Size(40, 41);
            this.miniBtn.TabIndex = 4;
            this.miniBtn.Text = "_";
            this.miniBtn.UseVisualStyleBackColor = false;
            this.miniBtn.Click += new System.EventHandler(this.miniBtn_Click);
            this.miniBtn.MouseEnter += new System.EventHandler(this.miniBtn_MouseEnter);
            this.miniBtn.MouseLeave += new System.EventHandler(this.miniBtn_MouseLeave);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.DimGray;
            this.closeBtn.Location = new System.Drawing.Point(586, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(40, 41);
            this.closeBtn.TabIndex = 3;
            this.closeBtn.Text = "x";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            this.closeBtn.MouseEnter += new System.EventHandler(this.closeBtn_MouseEnter);
            this.closeBtn.MouseLeave += new System.EventHandler(this.closeBtn_MouseLeave);
            // 
            // inputDataGroup
            // 
            this.inputDataGroup.BackColor = System.Drawing.Color.Transparent;
            this.inputDataGroup.Controls.Add(this.textBtn);
            this.inputDataGroup.Controls.Add(this.audiosBtn);
            this.inputDataGroup.Controls.Add(this.textTxt);
            this.inputDataGroup.Controls.Add(this.audiosTxt);
            this.inputDataGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inputDataGroup.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputDataGroup.ForeColor = System.Drawing.Color.Firebrick;
            this.inputDataGroup.Location = new System.Drawing.Point(0, 68);
            this.inputDataGroup.Name = "inputDataGroup";
            this.inputDataGroup.Size = new System.Drawing.Size(626, 98);
            this.inputDataGroup.TabIndex = 2;
            this.inputDataGroup.TabStop = false;
            this.inputDataGroup.Text = "Input Data";
            // 
            // textBtn
            // 
            this.textBtn.BackColor = System.Drawing.Color.Transparent;
            this.textBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBtn.FlatAppearance.BorderSize = 0;
            this.textBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.textBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBtn.ForeColor = System.Drawing.Color.DimGray;
            this.textBtn.Location = new System.Drawing.Point(539, 56);
            this.textBtn.Name = "textBtn";
            this.textBtn.Size = new System.Drawing.Size(75, 23);
            this.textBtn.TabIndex = 4;
            this.textBtn.Text = "Browse...";
            this.textBtn.UseVisualStyleBackColor = false;
            this.textBtn.Click += new System.EventHandler(this.textBtn_Click);
            this.textBtn.MouseEnter += new System.EventHandler(this.textBtn_MouseEnter);
            this.textBtn.MouseLeave += new System.EventHandler(this.textBtn_MouseLeave);
            // 
            // audiosBtn
            // 
            this.audiosBtn.BackColor = System.Drawing.Color.Transparent;
            this.audiosBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.audiosBtn.FlatAppearance.BorderSize = 0;
            this.audiosBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.audiosBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.audiosBtn.ForeColor = System.Drawing.Color.DimGray;
            this.audiosBtn.Location = new System.Drawing.Point(539, 27);
            this.audiosBtn.Name = "audiosBtn";
            this.audiosBtn.Size = new System.Drawing.Size(75, 23);
            this.audiosBtn.TabIndex = 3;
            this.audiosBtn.Text = "Browse...";
            this.audiosBtn.UseVisualStyleBackColor = false;
            this.audiosBtn.Click += new System.EventHandler(this.audiosBtn_Click);
            this.audiosBtn.MouseEnter += new System.EventHandler(this.audiosBtn_MouseEnter);
            this.audiosBtn.MouseLeave += new System.EventHandler(this.audiosBtn_MouseLeave);
            // 
            // textTxt
            // 
            this.textTxt.BackColor = System.Drawing.Color.White;
            this.textTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textTxt.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTxt.Location = new System.Drawing.Point(12, 56);
            this.textTxt.Multiline = true;
            this.textTxt.Name = "textTxt";
            this.textTxt.ReadOnly = true;
            this.textTxt.Size = new System.Drawing.Size(521, 23);
            this.textTxt.TabIndex = 1;
            this.textTxt.Text = "Please select the text file contain audio files details";
            this.textTxt.TextChanged += new System.EventHandler(this.textTxt_TextChanged);
            // 
            // audiosTxt
            // 
            this.audiosTxt.BackColor = System.Drawing.Color.White;
            this.audiosTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.audiosTxt.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.audiosTxt.Location = new System.Drawing.Point(12, 27);
            this.audiosTxt.Multiline = true;
            this.audiosTxt.Name = "audiosTxt";
            this.audiosTxt.ReadOnly = true;
            this.audiosTxt.Size = new System.Drawing.Size(521, 23);
            this.audiosTxt.TabIndex = 0;
            this.audiosTxt.Text = "Please select the folder contain audio files";
            this.audiosTxt.TextChanged += new System.EventHandler(this.audiosTxt_TextChanged);
            // 
            // audiosFolderBrowser
            // 
            this.audiosFolderBrowser.ShowNewFolderButton = false;
            // 
            // textFileBrowser
            // 
            this.textFileBrowser.Filter = "Text Files|*.txt";
            // 
            // outputDataGroup
            // 
            this.outputDataGroup.BackColor = System.Drawing.Color.Transparent;
            this.outputDataGroup.Controls.Add(this.timerPerFolderLbl);
            this.outputDataGroup.Controls.Add(this.timePerFolderTxt);
            this.outputDataGroup.Controls.Add(this.secPerFolderLbl);
            this.outputDataGroup.Controls.Add(this.secLbl);
            this.outputDataGroup.Controls.Add(this.audiosOutBtn);
            this.outputDataGroup.Controls.Add(this.audiosOutTxt);
            this.outputDataGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.outputDataGroup.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputDataGroup.ForeColor = System.Drawing.Color.Firebrick;
            this.outputDataGroup.Location = new System.Drawing.Point(0, 172);
            this.outputDataGroup.Name = "outputDataGroup";
            this.outputDataGroup.Size = new System.Drawing.Size(626, 98);
            this.outputDataGroup.TabIndex = 5;
            this.outputDataGroup.TabStop = false;
            this.outputDataGroup.Text = "Output Data";
            // 
            // timerPerFolderLbl
            // 
            this.timerPerFolderLbl.AutoSize = true;
            this.timerPerFolderLbl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerPerFolderLbl.Location = new System.Drawing.Point(12, 59);
            this.timerPerFolderLbl.Name = "timerPerFolderLbl";
            this.timerPerFolderLbl.Size = new System.Drawing.Size(87, 16);
            this.timerPerFolderLbl.TabIndex = 8;
            this.timerPerFolderLbl.Text = "Time/Folder: ";
            // 
            // timePerFolderTxt
            // 
            this.timePerFolderTxt.BackColor = System.Drawing.Color.White;
            this.timePerFolderTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timePerFolderTxt.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.timePerFolderTxt.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timePerFolderTxt.HideSelection = false;
            this.timePerFolderTxt.Location = new System.Drawing.Point(105, 56);
            this.timePerFolderTxt.Mask = "00:00:00";
            this.timePerFolderTxt.Name = "timePerFolderTxt";
            this.timePerFolderTxt.Size = new System.Drawing.Size(102, 23);
            this.timePerFolderTxt.TabIndex = 7;
            this.timePerFolderTxt.TextChanged += new System.EventHandler(this.timePerFolderTxt_TextChanged);
            // 
            // secPerFolderLbl
            // 
            this.secPerFolderLbl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secPerFolderLbl.Location = new System.Drawing.Point(416, 56);
            this.secPerFolderLbl.Name = "secPerFolderLbl";
            this.secPerFolderLbl.Size = new System.Drawing.Size(117, 23);
            this.secPerFolderLbl.TabIndex = 6;
            this.secPerFolderLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // secLbl
            // 
            this.secLbl.AutoSize = true;
            this.secLbl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secLbl.Location = new System.Drawing.Point(539, 58);
            this.secLbl.Name = "secLbl";
            this.secLbl.Size = new System.Drawing.Size(76, 16);
            this.secLbl.TabIndex = 5;
            this.secLbl.Text = "Secs/Folder";
            // 
            // audiosOutBtn
            // 
            this.audiosOutBtn.BackColor = System.Drawing.Color.Transparent;
            this.audiosOutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.audiosOutBtn.FlatAppearance.BorderSize = 0;
            this.audiosOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.audiosOutBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.audiosOutBtn.ForeColor = System.Drawing.Color.DimGray;
            this.audiosOutBtn.Location = new System.Drawing.Point(539, 27);
            this.audiosOutBtn.Name = "audiosOutBtn";
            this.audiosOutBtn.Size = new System.Drawing.Size(75, 23);
            this.audiosOutBtn.TabIndex = 3;
            this.audiosOutBtn.Text = "Browse...";
            this.audiosOutBtn.UseVisualStyleBackColor = false;
            this.audiosOutBtn.Click += new System.EventHandler(this.audiosOutBtn_Click);
            this.audiosOutBtn.MouseEnter += new System.EventHandler(this.audiosOutBtn_MouseEnter);
            this.audiosOutBtn.MouseLeave += new System.EventHandler(this.audiosOutBtn_MouseLeave);
            // 
            // audiosOutTxt
            // 
            this.audiosOutTxt.BackColor = System.Drawing.Color.White;
            this.audiosOutTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.audiosOutTxt.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.audiosOutTxt.Location = new System.Drawing.Point(12, 27);
            this.audiosOutTxt.Multiline = true;
            this.audiosOutTxt.Name = "audiosOutTxt";
            this.audiosOutTxt.ReadOnly = true;
            this.audiosOutTxt.Size = new System.Drawing.Size(521, 23);
            this.audiosOutTxt.TabIndex = 0;
            this.audiosOutTxt.Text = "Please select the folder to generate audio files";
            this.audiosOutTxt.TextChanged += new System.EventHandler(this.audiosOutTxt_TextChanged);
            // 
            // generateAudios
            // 
            this.generateAudios.BackColor = System.Drawing.Color.Transparent;
            this.generateAudios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generateAudios.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.generateAudios.Enabled = false;
            this.generateAudios.FlatAppearance.BorderSize = 0;
            this.generateAudios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateAudios.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateAudios.ForeColor = System.Drawing.Color.DimGray;
            this.generateAudios.Location = new System.Drawing.Point(0, 402);
            this.generateAudios.Name = "generateAudios";
            this.generateAudios.Size = new System.Drawing.Size(626, 50);
            this.generateAudios.TabIndex = 4;
            this.generateAudios.Text = "Generate Audio Files";
            this.generateAudios.UseVisualStyleBackColor = false;
            this.generateAudios.Click += new System.EventHandler(this.generateAudios_Click);
            this.generateAudios.MouseEnter += new System.EventHandler(this.generateAudios_MouseEnter);
            this.generateAudios.MouseLeave += new System.EventHandler(this.generateAudios_MouseLeave);
            // 
            // timersGroup
            // 
            this.timersGroup.BackColor = System.Drawing.Color.Transparent;
            this.timersGroup.Controls.Add(this.ff);
            this.timersGroup.Controls.Add(this.ffdls);
            this.timersGroup.Controls.Add(this.wfdpq);
            this.timersGroup.Controls.Add(this.wfdls);
            this.timersGroup.Controls.Add(this.wfpq);
            this.timersGroup.Controls.Add(this.wfls);
            this.timersGroup.Controls.Add(this.FFLbl);
            this.timersGroup.Controls.Add(this.FFDLSLbl);
            this.timersGroup.Controls.Add(this.WFDPQLbl);
            this.timersGroup.Controls.Add(this.WFDLSLbl);
            this.timersGroup.Controls.Add(this.WFPQLbl);
            this.timersGroup.Controls.Add(this.WFLSLbl);
            this.timersGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timersGroup.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timersGroup.ForeColor = System.Drawing.Color.Firebrick;
            this.timersGroup.Location = new System.Drawing.Point(0, 276);
            this.timersGroup.Name = "timersGroup";
            this.timersGroup.Size = new System.Drawing.Size(626, 98);
            this.timersGroup.TabIndex = 9;
            this.timersGroup.TabStop = false;
            this.timersGroup.Text = "Timers";
            // 
            // ff
            // 
            this.ff.Location = new System.Drawing.Point(493, 61);
            this.ff.Name = "ff";
            this.ff.Size = new System.Drawing.Size(121, 19);
            this.ff.TabIndex = 11;
            // 
            // ffdls
            // 
            this.ffdls.Location = new System.Drawing.Point(493, 32);
            this.ffdls.Name = "ffdls";
            this.ffdls.Size = new System.Drawing.Size(121, 19);
            this.ffdls.TabIndex = 10;
            // 
            // wfdpq
            // 
            this.wfdpq.Location = new System.Drawing.Point(286, 61);
            this.wfdpq.Name = "wfdpq";
            this.wfdpq.Size = new System.Drawing.Size(121, 19);
            this.wfdpq.TabIndex = 9;
            // 
            // wfdls
            // 
            this.wfdls.Location = new System.Drawing.Point(286, 32);
            this.wfdls.Name = "wfdls";
            this.wfdls.Size = new System.Drawing.Size(121, 19);
            this.wfdls.TabIndex = 8;
            // 
            // wfpq
            // 
            this.wfpq.Location = new System.Drawing.Point(76, 61);
            this.wfpq.Name = "wfpq";
            this.wfpq.Size = new System.Drawing.Size(121, 19);
            this.wfpq.TabIndex = 7;
            // 
            // wfls
            // 
            this.wfls.Location = new System.Drawing.Point(76, 32);
            this.wfls.Name = "wfls";
            this.wfls.Size = new System.Drawing.Size(121, 19);
            this.wfls.TabIndex = 6;
            // 
            // FFLbl
            // 
            this.FFLbl.AutoSize = true;
            this.FFLbl.Location = new System.Drawing.Point(428, 61);
            this.FFLbl.Name = "FFLbl";
            this.FFLbl.Size = new System.Drawing.Size(31, 19);
            this.FFLbl.TabIndex = 5;
            this.FFLbl.Text = "FF:";
            // 
            // FFDLSLbl
            // 
            this.FFDLSLbl.AutoSize = true;
            this.FFDLSLbl.Location = new System.Drawing.Point(428, 32);
            this.FFDLSLbl.Name = "FFDLSLbl";
            this.FFDLSLbl.Size = new System.Drawing.Size(59, 19);
            this.FFDLSLbl.TabIndex = 4;
            this.FFDLSLbl.Text = "FFDLS:";
            // 
            // WFDPQLbl
            // 
            this.WFDPQLbl.AutoSize = true;
            this.WFDPQLbl.Location = new System.Drawing.Point(211, 61);
            this.WFDPQLbl.Name = "WFDPQLbl";
            this.WFDPQLbl.Size = new System.Drawing.Size(69, 19);
            this.WFDPQLbl.TabIndex = 3;
            this.WFDPQLbl.Text = "WFDPQ:";
            // 
            // WFDLSLbl
            // 
            this.WFDLSLbl.AutoSize = true;
            this.WFDLSLbl.Location = new System.Drawing.Point(211, 32);
            this.WFDLSLbl.Name = "WFDLSLbl";
            this.WFDLSLbl.Size = new System.Drawing.Size(65, 19);
            this.WFDLSLbl.TabIndex = 2;
            this.WFDLSLbl.Text = "WFDLS:";
            // 
            // WFPQLbl
            // 
            this.WFPQLbl.AutoSize = true;
            this.WFPQLbl.Location = new System.Drawing.Point(12, 61);
            this.WFPQLbl.Name = "WFPQLbl";
            this.WFPQLbl.Size = new System.Drawing.Size(58, 19);
            this.WFPQLbl.TabIndex = 1;
            this.WFPQLbl.Text = "WFPQ:";
            // 
            // WFLSLbl
            // 
            this.WFLSLbl.AutoSize = true;
            this.WFLSLbl.Location = new System.Drawing.Point(12, 32);
            this.WFLSLbl.Name = "WFLSLbl";
            this.WFLSLbl.Size = new System.Drawing.Size(54, 19);
            this.WFLSLbl.TabIndex = 0;
            this.WFLSLbl.Text = "WFLS:";
            // 
            // genTimer
            // 
            this.genTimer.Enabled = true;
            this.genTimer.Tick += new System.EventHandler(this.genTimer_Tick);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(626, 452);
            this.Controls.Add(this.timersGroup);
            this.Controls.Add(this.generateAudios);
            this.Controls.Add(this.outputDataGroup);
            this.Controls.Add(this.inputDataGroup);
            this.Controls.Add(this.controlPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainForm";
            this.controlPanel.ResumeLayout(false);
            this.inputDataGroup.ResumeLayout(false);
            this.inputDataGroup.PerformLayout();
            this.outputDataGroup.ResumeLayout(false);
            this.outputDataGroup.PerformLayout();
            this.timersGroup.ResumeLayout(false);
            this.timersGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.GroupBox inputDataGroup;
        private System.Windows.Forms.Button textBtn;
        private System.Windows.Forms.Button audiosBtn;
        private System.Windows.Forms.TextBox textTxt;
        private System.Windows.Forms.TextBox audiosTxt;
        private System.Windows.Forms.Label controlLbl;
        private System.Windows.Forms.FolderBrowserDialog audiosFolderBrowser;
        private System.Windows.Forms.OpenFileDialog textFileBrowser;
        private System.Windows.Forms.GroupBox outputDataGroup;
        private System.Windows.Forms.Button audiosOutBtn;
        private System.Windows.Forms.TextBox audiosOutTxt;
        private System.Windows.Forms.Button generateAudios;
        private System.Windows.Forms.Button miniBtn;
        private System.Windows.Forms.Label timerPerFolderLbl;
        private System.Windows.Forms.MaskedTextBox timePerFolderTxt;
        private System.Windows.Forms.Label secPerFolderLbl;
        private System.Windows.Forms.Label secLbl;
        private System.Windows.Forms.GroupBox timersGroup;
        private System.Windows.Forms.Label WFLSLbl;
        private System.Windows.Forms.Label ff;
        private System.Windows.Forms.Label ffdls;
        private System.Windows.Forms.Label wfdpq;
        private System.Windows.Forms.Label wfdls;
        private System.Windows.Forms.Label wfpq;
        private System.Windows.Forms.Label wfls;
        private System.Windows.Forms.Label FFLbl;
        private System.Windows.Forms.Label FFDLSLbl;
        private System.Windows.Forms.Label WFDPQLbl;
        private System.Windows.Forms.Label WFDLSLbl;
        private System.Windows.Forms.Label WFPQLbl;
        private System.Windows.Forms.Timer genTimer;
    }
}