
namespace MORZE
{
    partial class KezdoOldal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KezdoOldal));
            this.Jelkeszlet = new System.Windows.Forms.ListBox();
            this.Dekodolas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Kodolas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bezaras = new System.Windows.Forms.Button();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Jelkeszlet
            // 
            this.Jelkeszlet.FormattingEnabled = true;
            this.Jelkeszlet.ItemHeight = 16;
            this.Jelkeszlet.Location = new System.Drawing.Point(49, 145);
            this.Jelkeszlet.Name = "Jelkeszlet";
            this.Jelkeszlet.Size = new System.Drawing.Size(486, 20);
            this.Jelkeszlet.TabIndex = 2;
            // 
            // Dekodolas
            // 
            this.Dekodolas.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Dekodolas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Dekodolas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Dekodolas.BorderRadius = 0;
            this.Dekodolas.ButtonText = "Dekódolás";
            this.Dekodolas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dekodolas.DisabledColor = System.Drawing.Color.Gray;
            this.Dekodolas.Iconcolor = System.Drawing.Color.Transparent;
            this.Dekodolas.Iconimage = ((System.Drawing.Image)(resources.GetObject("Dekodolas.Iconimage")));
            this.Dekodolas.Iconimage_right = null;
            this.Dekodolas.Iconimage_right_Selected = null;
            this.Dekodolas.Iconimage_Selected = null;
            this.Dekodolas.IconMarginLeft = 0;
            this.Dekodolas.IconMarginRight = 0;
            this.Dekodolas.IconRightVisible = true;
            this.Dekodolas.IconRightZoom = 0D;
            this.Dekodolas.IconVisible = true;
            this.Dekodolas.IconZoom = 90D;
            this.Dekodolas.IsTab = false;
            this.Dekodolas.Location = new System.Drawing.Point(302, 57);
            this.Dekodolas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Dekodolas.Name = "Dekodolas";
            this.Dekodolas.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Dekodolas.OnHovercolor = System.Drawing.Color.Blue;
            this.Dekodolas.OnHoverTextColor = System.Drawing.Color.White;
            this.Dekodolas.selected = false;
            this.Dekodolas.Size = new System.Drawing.Size(253, 59);
            this.Dekodolas.TabIndex = 1;
            this.Dekodolas.Text = "Dekódolás";
            this.Dekodolas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Dekodolas.Textcolor = System.Drawing.Color.White;
            this.Dekodolas.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dekodolas.Click += new System.EventHandler(this.Dekodolas_Click);
            // 
            // Kodolas
            // 
            this.Kodolas.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Kodolas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Kodolas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Kodolas.BorderRadius = 0;
            this.Kodolas.ButtonText = "Kódolás";
            this.Kodolas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Kodolas.DisabledColor = System.Drawing.Color.Gray;
            this.Kodolas.Iconcolor = System.Drawing.Color.Transparent;
            this.Kodolas.Iconimage = ((System.Drawing.Image)(resources.GetObject("Kodolas.Iconimage")));
            this.Kodolas.Iconimage_right = null;
            this.Kodolas.Iconimage_right_Selected = null;
            this.Kodolas.Iconimage_Selected = null;
            this.Kodolas.IconMarginLeft = 0;
            this.Kodolas.IconMarginRight = 0;
            this.Kodolas.IconRightVisible = true;
            this.Kodolas.IconRightZoom = 0D;
            this.Kodolas.IconVisible = true;
            this.Kodolas.IconZoom = 90D;
            this.Kodolas.IsTab = false;
            this.Kodolas.Location = new System.Drawing.Point(13, 57);
            this.Kodolas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Kodolas.Name = "Kodolas";
            this.Kodolas.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Kodolas.OnHovercolor = System.Drawing.Color.Blue;
            this.Kodolas.OnHoverTextColor = System.Drawing.Color.White;
            this.Kodolas.selected = false;
            this.Kodolas.Size = new System.Drawing.Size(253, 59);
            this.Kodolas.TabIndex = 0;
            this.Kodolas.Text = "Kódolás";
            this.Kodolas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Kodolas.Textcolor = System.Drawing.Color.White;
            this.Kodolas.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kodolas.Click += new System.EventHandler(this.Kodolas_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this;
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
            this.bezaras.Location = new System.Drawing.Point(521, 12);
            this.bezaras.Name = "bezaras";
            this.bezaras.Size = new System.Drawing.Size(35, 36);
            this.bezaras.TabIndex = 14;
            this.bezaras.UseVisualStyleBackColor = false;
            this.bezaras.Click += new System.EventHandler(this.bezaras_Click);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.DodgerBlue;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.DodgerBlue;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.LawnGreen;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.DodgerBlue;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(568, 184);
            this.bunifuGradientPanel1.TabIndex = 15;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(237, 13);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(99, 28);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "MORZE ";
            // 
            // KezdoOldal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 184);
            this.Controls.Add(this.bezaras);
            this.Controls.Add(this.Jelkeszlet);
            this.Controls.Add(this.Dekodolas);
            this.Controls.Add(this.Kodolas);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KezdoOldal";
            this.Text = "Morze CODE";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton Kodolas;
        private Bunifu.Framework.UI.BunifuFlatButton Dekodolas;
        private System.Windows.Forms.ListBox Jelkeszlet;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button bezaras;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}

