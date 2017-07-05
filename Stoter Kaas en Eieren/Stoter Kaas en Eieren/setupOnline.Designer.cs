namespace Stoter_Kaas_en_Eieren
{
    partial class setupOnline
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(setupOnline));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.background = new AxWMPLib.AxWindowsMediaPlayer();
            this.topbackground = new System.Windows.Forms.PictureBox();
            this.naam1_label = new System.Windows.Forms.Label();
            this.naam2_label = new System.Windows.Forms.Label();
            this.naam2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.naam1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.aantal1_label = new System.Windows.Forms.Label();
            this.aantal2_label = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tijd2_label = new System.Windows.Forms.Label();
            this.tijd1_label = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.status1 = new System.Windows.Forms.PictureBox();
            this.status2 = new System.Windows.Forms.PictureBox();
            this.aantal1 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.comboItem4 = new DevComponents.Editors.ComboItem();
            this.tijd1 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem9 = new DevComponents.Editors.ComboItem();
            this.comboItem10 = new DevComponents.Editors.ComboItem();
            this.comboItem11 = new DevComponents.Editors.ComboItem();
            this.herlder = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topbackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.status1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.status2)).BeginInit();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.Enabled = true;
            this.background.Location = new System.Drawing.Point(-34, -55);
            this.background.Name = "background";
            this.background.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("background.OcxState")));
            this.background.Size = new System.Drawing.Size(1230, 864);
            this.background.TabIndex = 175;
            // 
            // topbackground
            // 
            this.topbackground.Image = global::Stoter_Kaas_en_Eieren.Properties.Resources.spelletje;
            this.topbackground.Location = new System.Drawing.Point(0, 0);
            this.topbackground.Name = "topbackground";
            this.topbackground.Size = new System.Drawing.Size(1120, 502);
            this.topbackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.topbackground.TabIndex = 176;
            this.topbackground.TabStop = false;
            // 
            // naam1_label
            // 
            this.naam1_label.AutoSize = true;
            this.naam1_label.BackColor = System.Drawing.Color.Transparent;
            this.naam1_label.Font = new System.Drawing.Font("Supersonic Rocketship", 30F);
            this.naam1_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(89)))), ((int)(((byte)(156)))));
            this.naam1_label.Location = new System.Drawing.Point(313, 115);
            this.naam1_label.Name = "naam1_label";
            this.naam1_label.Size = new System.Drawing.Size(311, 60);
            this.naam1_label.TabIndex = 177;
            this.naam1_label.Text = "In afwachting...";
            this.naam1_label.Visible = false;
            // 
            // naam2_label
            // 
            this.naam2_label.AutoSize = true;
            this.naam2_label.BackColor = System.Drawing.Color.Transparent;
            this.naam2_label.Font = new System.Drawing.Font("Supersonic Rocketship", 30F);
            this.naam2_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(89)))), ((int)(((byte)(156)))));
            this.naam2_label.Location = new System.Drawing.Point(822, 116);
            this.naam2_label.Name = "naam2_label";
            this.naam2_label.Size = new System.Drawing.Size(312, 60);
            this.naam2_label.TabIndex = 178;
            this.naam2_label.Text = "in afwachting...";
            this.naam2_label.Visible = false;
            // 
            // naam2
            // 
            // 
            // 
            // 
            this.naam2.Border.Class = "TextBoxBorder";
            this.naam2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.naam2.Font = new System.Drawing.Font("Supersonic Rocketship", 30F);
            this.naam2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(89)))), ((int)(((byte)(156)))));
            this.naam2.Location = new System.Drawing.Point(832, 114);
            this.naam2.MaxLength = 15;
            this.naam2.Name = "naam2";
            this.naam2.PreventEnterBeep = true;
            this.naam2.Size = new System.Drawing.Size(263, 67);
            this.naam2.TabIndex = 180;
            this.naam2.Text = "naam";
            this.naam2.Visible = false;
            // 
            // naam1
            // 
            // 
            // 
            // 
            this.naam1.Border.Class = "TextBoxBorder";
            this.naam1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.naam1.Font = new System.Drawing.Font("Supersonic Rocketship", 30F);
            this.naam1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(89)))), ((int)(((byte)(156)))));
            this.naam1.Location = new System.Drawing.Point(323, 114);
            this.naam1.MaxLength = 15;
            this.naam1.Name = "naam1";
            this.naam1.PreventEnterBeep = true;
            this.naam1.Size = new System.Drawing.Size(263, 67);
            this.naam1.TabIndex = 181;
            this.naam1.Text = "naam";
            this.naam1.Visible = false;
            // 
            // aantal1_label
            // 
            this.aantal1_label.AutoSize = true;
            this.aantal1_label.BackColor = System.Drawing.Color.Transparent;
            this.aantal1_label.Font = new System.Drawing.Font("Supersonic Rocketship", 30F);
            this.aantal1_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(89)))), ((int)(((byte)(156)))));
            this.aantal1_label.Location = new System.Drawing.Point(313, 209);
            this.aantal1_label.Name = "aantal1_label";
            this.aantal1_label.Size = new System.Drawing.Size(311, 60);
            this.aantal1_label.TabIndex = 182;
            this.aantal1_label.Text = "In afwachting...";
            this.aantal1_label.Visible = false;
            // 
            // aantal2_label
            // 
            this.aantal2_label.AutoSize = true;
            this.aantal2_label.BackColor = System.Drawing.Color.Transparent;
            this.aantal2_label.Font = new System.Drawing.Font("Supersonic Rocketship", 30F);
            this.aantal2_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(89)))), ((int)(((byte)(156)))));
            this.aantal2_label.Location = new System.Drawing.Point(822, 210);
            this.aantal2_label.Name = "aantal2_label";
            this.aantal2_label.Size = new System.Drawing.Size(311, 60);
            this.aantal2_label.TabIndex = 183;
            this.aantal2_label.Text = "In afwachting...";
            // 
            // tijd2_label
            // 
            this.tijd2_label.AutoSize = true;
            this.tijd2_label.BackColor = System.Drawing.Color.Transparent;
            this.tijd2_label.Font = new System.Drawing.Font("Supersonic Rocketship", 30F);
            this.tijd2_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(89)))), ((int)(((byte)(156)))));
            this.tijd2_label.Location = new System.Drawing.Point(822, 296);
            this.tijd2_label.Name = "tijd2_label";
            this.tijd2_label.Size = new System.Drawing.Size(311, 60);
            this.tijd2_label.TabIndex = 187;
            this.tijd2_label.Text = "In afwachting...";
            // 
            // tijd1_label
            // 
            this.tijd1_label.AutoSize = true;
            this.tijd1_label.BackColor = System.Drawing.Color.Transparent;
            this.tijd1_label.Font = new System.Drawing.Font("Supersonic Rocketship", 30F);
            this.tijd1_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(89)))), ((int)(((byte)(156)))));
            this.tijd1_label.Location = new System.Drawing.Point(313, 296);
            this.tijd1_label.Name = "tijd1_label";
            this.tijd1_label.Size = new System.Drawing.Size(311, 60);
            this.tijd1_label.TabIndex = 186;
            this.tijd1_label.Text = "In afwachting...";
            this.tijd1_label.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Stoter_Kaas_en_Eieren.Properties.Resources.volgende2;
            this.pictureBox1.Location = new System.Drawing.Point(929, 443);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 194;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // status1
            // 
            this.status1.BackColor = System.Drawing.Color.Transparent;
            this.status1.Image = global::Stoter_Kaas_en_Eieren.Properties.Resources.notready;
            this.status1.Location = new System.Drawing.Point(312, 382);
            this.status1.Name = "status1";
            this.status1.Size = new System.Drawing.Size(74, 67);
            this.status1.TabIndex = 195;
            this.status1.TabStop = false;
            // 
            // status2
            // 
            this.status2.BackColor = System.Drawing.Color.Transparent;
            this.status2.Image = global::Stoter_Kaas_en_Eieren.Properties.Resources.notready;
            this.status2.Location = new System.Drawing.Point(827, 382);
            this.status2.Name = "status2";
            this.status2.Size = new System.Drawing.Size(74, 67);
            this.status2.TabIndex = 196;
            this.status2.TabStop = false;
            // 
            // aantal1
            // 
            this.aantal1.DisplayMember = "Text";
            this.aantal1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.aantal1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aantal1.Font = new System.Drawing.Font("Supersonic Rocketship", 30F);
            this.aantal1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(89)))), ((int)(((byte)(156)))));
            this.aantal1.FormattingEnabled = true;
            this.aantal1.ItemHeight = 62;
            this.aantal1.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2,
            this.comboItem3,
            this.comboItem4});
            this.aantal1.Location = new System.Drawing.Point(323, 202);
            this.aantal1.Name = "aantal1";
            this.aantal1.Size = new System.Drawing.Size(263, 68);
            this.aantal1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.aantal1.TabIndex = 197;
            this.aantal1.Visible = false;
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "3 potjes";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "5 potjes";
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "10 potjes";
            // 
            // comboItem4
            // 
            this.comboItem4.Text = "15 potjes";
            // 
            // tijd1
            // 
            this.tijd1.DisplayMember = "Text";
            this.tijd1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.tijd1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tijd1.Font = new System.Drawing.Font("Supersonic Rocketship", 30F);
            this.tijd1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(89)))), ((int)(((byte)(156)))));
            this.tijd1.FormattingEnabled = true;
            this.tijd1.ItemHeight = 62;
            this.tijd1.Items.AddRange(new object[] {
            this.comboItem9,
            this.comboItem10,
            this.comboItem11});
            this.tijd1.Location = new System.Drawing.Point(323, 294);
            this.tijd1.Name = "tijd1";
            this.tijd1.Size = new System.Drawing.Size(263, 68);
            this.tijd1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.tijd1.TabIndex = 198;
            this.tijd1.Visible = false;
            // 
            // comboItem9
            // 
            this.comboItem9.Text = "5 sec";
            // 
            // comboItem10
            // 
            this.comboItem10.Text = "7 sec";
            // 
            // comboItem11
            // 
            this.comboItem11.Text = "10 sec";
            // 
            // herlder
            // 
            this.herlder.Tick += new System.EventHandler(this.herlder_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 0);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 199;
            this.progressBar1.Visible = false;
            // 
            // setupOnline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Stoter_Kaas_en_Eieren.Properties.Resources.spelletje;
            this.ClientSize = new System.Drawing.Size(1120, 693);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.tijd1);
            this.Controls.Add(this.aantal1);
            this.Controls.Add(this.status2);
            this.Controls.Add(this.status1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tijd2_label);
            this.Controls.Add(this.tijd1_label);
            this.Controls.Add(this.aantal2_label);
            this.Controls.Add(this.aantal1_label);
            this.Controls.Add(this.naam1);
            this.Controls.Add(this.naam2);
            this.Controls.Add(this.naam2_label);
            this.Controls.Add(this.naam1_label);
            this.Controls.Add(this.topbackground);
            this.Controls.Add(this.background);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "setupOnline";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stoter Kaas en Eieren - Setup online";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.setupOnline_FormClosing);
            this.Load += new System.EventHandler(this.setupOnline_Load);
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topbackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.status1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.status2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox topbackground;
        private AxWMPLib.AxWindowsMediaPlayer background;
        private System.Windows.Forms.Label naam1_label;
        private System.Windows.Forms.Label naam2_label;
        private DevComponents.DotNetBar.Controls.TextBoxX naam2;
        private DevComponents.DotNetBar.Controls.TextBoxX naam1;
        private System.Windows.Forms.Label aantal1_label;
        private System.Windows.Forms.Label aantal2_label;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label tijd2_label;
        private System.Windows.Forms.Label tijd1_label;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox status1;
        private System.Windows.Forms.PictureBox status2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx aantal1;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.Editors.ComboItem comboItem4;
        private DevComponents.DotNetBar.Controls.ComboBoxEx tijd1;
        private DevComponents.Editors.ComboItem comboItem9;
        private DevComponents.Editors.ComboItem comboItem10;
        private DevComponents.Editors.ComboItem comboItem11;
        private System.Windows.Forms.Timer herlder;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}