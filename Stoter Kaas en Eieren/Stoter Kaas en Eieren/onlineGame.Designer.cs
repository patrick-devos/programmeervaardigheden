namespace Stoter_Kaas_en_Eieren
{
    partial class onlineGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(onlineGame));
            this.background = new AxWMPLib.AxWindowsMediaPlayer();
            this.topbackground = new System.Windows.Forms.PictureBox();
            this.speler1 = new System.Windows.Forms.Label();
            this.speler2 = new System.Windows.Forms.Label();
            this.score1 = new System.Windows.Forms.Label();
            this.score2 = new System.Windows.Forms.Label();
            this.kn33 = new System.Windows.Forms.PictureBox();
            this.kn32 = new System.Windows.Forms.PictureBox();
            this.kn31 = new System.Windows.Forms.PictureBox();
            this.kn25 = new System.Windows.Forms.PictureBox();
            this.kn24 = new System.Windows.Forms.PictureBox();
            this.kn19 = new System.Windows.Forms.PictureBox();
            this.kn18 = new System.Windows.Forms.PictureBox();
            this.kn17 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.eindscore = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.herlader = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topbackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kn33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kn32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kn31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kn25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kn24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kn19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kn18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kn17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.Enabled = true;
            this.background.Location = new System.Drawing.Point(-34, -55);
            this.background.Name = "background";
            this.background.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("background.OcxState")));
            this.background.Size = new System.Drawing.Size(1230, 864);
            this.background.TabIndex = 200;
            // 
            // topbackground
            // 
            this.topbackground.BackgroundImage = global::Stoter_Kaas_en_Eieren.Properties.Resources.degame;
            this.topbackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.topbackground.Location = new System.Drawing.Point(0, 0);
            this.topbackground.Name = "topbackground";
            this.topbackground.Size = new System.Drawing.Size(1120, 502);
            this.topbackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.topbackground.TabIndex = 201;
            this.topbackground.TabStop = false;
            // 
            // speler1
            // 
            this.speler1.AutoSize = true;
            this.speler1.BackColor = System.Drawing.Color.Transparent;
            this.speler1.Font = new System.Drawing.Font("Supersonic Rocketship", 30F);
            this.speler1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(89)))), ((int)(((byte)(156)))));
            this.speler1.Location = new System.Drawing.Point(12, 9);
            this.speler1.Name = "speler1";
            this.speler1.Size = new System.Drawing.Size(161, 60);
            this.speler1.TabIndex = 203;
            this.speler1.Text = "speler1";
            // 
            // speler2
            // 
            this.speler2.AutoSize = true;
            this.speler2.BackColor = System.Drawing.Color.Transparent;
            this.speler2.Font = new System.Drawing.Font("Supersonic Rocketship", 30F);
            this.speler2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(89)))), ((int)(((byte)(156)))));
            this.speler2.Location = new System.Drawing.Point(12, 69);
            this.speler2.Name = "speler2";
            this.speler2.Size = new System.Drawing.Size(167, 60);
            this.speler2.TabIndex = 204;
            this.speler2.Text = "speler2";
            // 
            // score1
            // 
            this.score1.AutoSize = true;
            this.score1.BackColor = System.Drawing.Color.Transparent;
            this.score1.Font = new System.Drawing.Font("Supersonic Rocketship", 30F);
            this.score1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(89)))), ((int)(((byte)(156)))));
            this.score1.Location = new System.Drawing.Point(301, 9);
            this.score1.Name = "score1";
            this.score1.Size = new System.Drawing.Size(46, 60);
            this.score1.TabIndex = 205;
            this.score1.Text = "0";
            // 
            // score2
            // 
            this.score2.AutoSize = true;
            this.score2.BackColor = System.Drawing.Color.Transparent;
            this.score2.Font = new System.Drawing.Font("Supersonic Rocketship", 30F);
            this.score2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(89)))), ((int)(((byte)(156)))));
            this.score2.Location = new System.Drawing.Point(301, 69);
            this.score2.Name = "score2";
            this.score2.Size = new System.Drawing.Size(46, 60);
            this.score2.TabIndex = 206;
            this.score2.Text = "0";
            // 
            // kn33
            // 
            this.kn33.BackColor = System.Drawing.Color.Transparent;
            this.kn33.Image = ((System.Drawing.Image)(resources.GetObject("kn33.Image")));
            this.kn33.Location = new System.Drawing.Point(616, 395);
            this.kn33.Name = "kn33";
            this.kn33.Size = new System.Drawing.Size(100, 100);
            this.kn33.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kn33.TabIndex = 214;
            this.kn33.TabStop = false;
            // 
            // kn32
            // 
            this.kn32.BackColor = System.Drawing.Color.Transparent;
            this.kn32.Image = ((System.Drawing.Image)(resources.GetObject("kn32.Image")));
            this.kn32.Location = new System.Drawing.Point(510, 395);
            this.kn32.Name = "kn32";
            this.kn32.Size = new System.Drawing.Size(100, 100);
            this.kn32.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kn32.TabIndex = 213;
            this.kn32.TabStop = false;
            // 
            // kn31
            // 
            this.kn31.BackColor = System.Drawing.Color.Transparent;
            this.kn31.Image = ((System.Drawing.Image)(resources.GetObject("kn31.Image")));
            this.kn31.Location = new System.Drawing.Point(404, 395);
            this.kn31.Name = "kn31";
            this.kn31.Size = new System.Drawing.Size(100, 100);
            this.kn31.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kn31.TabIndex = 212;
            this.kn31.TabStop = false;
            // 
            // kn25
            // 
            this.kn25.BackColor = System.Drawing.Color.Transparent;
            this.kn25.Image = ((System.Drawing.Image)(resources.GetObject("kn25.Image")));
            this.kn25.Location = new System.Drawing.Point(510, 289);
            this.kn25.Name = "kn25";
            this.kn25.Size = new System.Drawing.Size(100, 100);
            this.kn25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kn25.TabIndex = 211;
            this.kn25.TabStop = false;
            // 
            // kn24
            // 
            this.kn24.BackColor = System.Drawing.Color.Transparent;
            this.kn24.Image = ((System.Drawing.Image)(resources.GetObject("kn24.Image")));
            this.kn24.Location = new System.Drawing.Point(404, 289);
            this.kn24.Name = "kn24";
            this.kn24.Size = new System.Drawing.Size(100, 100);
            this.kn24.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kn24.TabIndex = 210;
            this.kn24.TabStop = false;
            this.kn24.Click += new System.EventHandler(this.kn24_Click);
            // 
            // kn19
            // 
            this.kn19.BackColor = System.Drawing.Color.Transparent;
            this.kn19.Image = ((System.Drawing.Image)(resources.GetObject("kn19.Image")));
            this.kn19.Location = new System.Drawing.Point(616, 183);
            this.kn19.Name = "kn19";
            this.kn19.Size = new System.Drawing.Size(100, 100);
            this.kn19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kn19.TabIndex = 209;
            this.kn19.TabStop = false;
            // 
            // kn18
            // 
            this.kn18.BackColor = System.Drawing.Color.Transparent;
            this.kn18.Image = ((System.Drawing.Image)(resources.GetObject("kn18.Image")));
            this.kn18.Location = new System.Drawing.Point(510, 183);
            this.kn18.Name = "kn18";
            this.kn18.Size = new System.Drawing.Size(100, 100);
            this.kn18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kn18.TabIndex = 208;
            this.kn18.TabStop = false;
            this.kn18.Click += new System.EventHandler(this.kn18_Click);
            // 
            // kn17
            // 
            this.kn17.BackColor = System.Drawing.Color.Transparent;
            this.kn17.Image = global::Stoter_Kaas_en_Eieren.Properties.Resources.img;
            this.kn17.Location = new System.Drawing.Point(404, 183);
            this.kn17.Name = "kn17";
            this.kn17.Size = new System.Drawing.Size(100, 100);
            this.kn17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kn17.TabIndex = 207;
            this.kn17.TabStop = false;
            this.kn17.Click += new System.EventHandler(this.kn17_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(616, 289);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 215;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Supersonic Rocketship", 30F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(89)))), ((int)(((byte)(156)))));
            this.label4.Location = new System.Drawing.Point(12, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 60);
            this.label4.TabIndex = 216;
            this.label4.Text = "Einde";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // eindscore
            // 
            this.eindscore.AutoSize = true;
            this.eindscore.BackColor = System.Drawing.Color.Transparent;
            this.eindscore.Font = new System.Drawing.Font("Supersonic Rocketship", 30F);
            this.eindscore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(89)))), ((int)(((byte)(156)))));
            this.eindscore.Location = new System.Drawing.Point(301, 129);
            this.eindscore.Name = "eindscore";
            this.eindscore.Size = new System.Drawing.Size(183, 60);
            this.eindscore.TabIndex = 217;
            this.eindscore.Text = "3 potjes";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(77, 274);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(196, 183);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 218;
            this.pictureBox2.TabStop = false;
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007VistaGlass;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199))))));
            // 
            // herlader
            // 
            this.herlader.Tick += new System.EventHandler(this.herlader_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(30, 183);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 219;
            this.progressBar1.Visible = false;
            // 
            // onlineGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Stoter_Kaas_en_Eieren.Properties.Resources.degame;
            this.ClientSize = new System.Drawing.Size(1120, 693);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.kn33);
            this.Controls.Add(this.kn32);
            this.Controls.Add(this.kn31);
            this.Controls.Add(this.kn25);
            this.Controls.Add(this.kn24);
            this.Controls.Add(this.kn19);
            this.Controls.Add(this.kn18);
            this.Controls.Add(this.kn17);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.eindscore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.score2);
            this.Controls.Add(this.score1);
            this.Controls.Add(this.speler2);
            this.Controls.Add(this.speler1);
            this.Controls.Add(this.topbackground);
            this.Controls.Add(this.background);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "onlineGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stoter Kaas en Eieren";
            this.Load += new System.EventHandler(this.onlineGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topbackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kn33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kn32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kn31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kn25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kn24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kn19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kn18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kn17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox topbackground;
        private AxWMPLib.AxWindowsMediaPlayer background;
        private System.Windows.Forms.Label speler1;
        private System.Windows.Forms.Label speler2;
        private System.Windows.Forms.Label score1;
        private System.Windows.Forms.Label score2;
        private System.Windows.Forms.PictureBox kn33;
        private System.Windows.Forms.PictureBox kn32;
        private System.Windows.Forms.PictureBox kn31;
        private System.Windows.Forms.PictureBox kn25;
        private System.Windows.Forms.PictureBox kn24;
        private System.Windows.Forms.PictureBox kn19;
        private System.Windows.Forms.PictureBox kn18;
        private System.Windows.Forms.PictureBox kn17;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label eindscore;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private System.Windows.Forms.Timer herlader;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}