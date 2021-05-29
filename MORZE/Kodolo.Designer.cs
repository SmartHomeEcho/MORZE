
namespace MORZE
{
    partial class Kodolo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kodolo));
            this.ForditandoTextBox = new System.Windows.Forms.TextBox();
            this.ForditottTextBox = new System.Windows.Forms.TextBox();
            this.TorlesGomb = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bezaras = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ForditandoTextBox
            // 
            this.ForditandoTextBox.Location = new System.Drawing.Point(44, 72);
            this.ForditandoTextBox.Multiline = true;
            this.ForditandoTextBox.Name = "ForditandoTextBox";
            this.ForditandoTextBox.Size = new System.Drawing.Size(567, 111);
            this.ForditandoTextBox.TabIndex = 4;
            this.ForditandoTextBox.TextChanged += new System.EventHandler(this.Forditando_TextChanged);
            // 
            // ForditottTextBox
            // 
            this.ForditottTextBox.Location = new System.Drawing.Point(44, 240);
            this.ForditottTextBox.Multiline = true;
            this.ForditottTextBox.Name = "ForditottTextBox";
            this.ForditottTextBox.Size = new System.Drawing.Size(567, 111);
            this.ForditottTextBox.TabIndex = 7;
            // 
            // TorlesGomb
            // 
            this.TorlesGomb.ActiveBorderThickness = 1;
            this.TorlesGomb.ActiveCornerRadius = 20;
            this.TorlesGomb.ActiveFillColor = System.Drawing.Color.Blue;
            this.TorlesGomb.ActiveForecolor = System.Drawing.Color.White;
            this.TorlesGomb.ActiveLineColor = System.Drawing.Color.Blue;
            this.TorlesGomb.BackColor = System.Drawing.SystemColors.Control;
            this.TorlesGomb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TorlesGomb.BackgroundImage")));
            this.TorlesGomb.ButtonText = "Törlés";
            this.TorlesGomb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TorlesGomb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TorlesGomb.ForeColor = System.Drawing.Color.Blue;
            this.TorlesGomb.IdleBorderThickness = 1;
            this.TorlesGomb.IdleCornerRadius = 20;
            this.TorlesGomb.IdleFillColor = System.Drawing.Color.White;
            this.TorlesGomb.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.TorlesGomb.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.TorlesGomb.Location = new System.Drawing.Point(430, 191);
            this.TorlesGomb.Margin = new System.Windows.Forms.Padding(5);
            this.TorlesGomb.Name = "TorlesGomb";
            this.TorlesGomb.Size = new System.Drawing.Size(181, 41);
            this.TorlesGomb.TabIndex = 11;
            this.TorlesGomb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TorlesGomb.Click += new System.EventHandler(this.TorlesGomb_Click);
            // 
            // bezaras
            // 
            this.bezaras.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bezaras.BackColor = System.Drawing.Color.Black;
            this.bezaras.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.bezaras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.bezaras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bezaras.ForeColor = System.Drawing.Color.Red;
            this.bezaras.Image = ((System.Drawing.Image)(resources.GetObject("bezaras.Image")));
            this.bezaras.Location = new System.Drawing.Point(601, 12);
            this.bezaras.Name = "bezaras";
            this.bezaras.Size = new System.Drawing.Size(35, 36);
            this.bezaras.TabIndex = 12;
            this.bezaras.UseVisualStyleBackColor = false;
            this.bezaras.Click += new System.EventHandler(this.bezaras_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel2);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.DodgerBlue;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.DodgerBlue;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.LawnGreen;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.DodgerBlue;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(652, 398);
            this.bunifuGradientPanel1.TabIndex = 13;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(40, 40);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(270, 19);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Add meg a fordítandó szöveget";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(40, 213);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(249, 19);
            this.bunifuCustomLabel2.TabIndex = 2;
            this.bunifuCustomLabel2.Text = "A kódolt szöveg a következő";
            // 
            // Kodolo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 398);
            this.Controls.Add(this.bezaras);
            this.Controls.Add(this.TorlesGomb);
            this.Controls.Add(this.ForditottTextBox);
            this.Controls.Add(this.ForditandoTextBox);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Kodolo";
            this.Text = "Kodolo";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ForditandoTextBox;
        private System.Windows.Forms.TextBox ForditottTextBox;
        private Bunifu.Framework.UI.BunifuThinButton2 TorlesGomb;
        private System.Windows.Forms.Button bezaras;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}