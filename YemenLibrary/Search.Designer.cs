namespace YemenLibrary
{
    partial class Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.txt_search = new Bunifu.Framework.UI.BunifuTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.Button_Name = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Button_Gnre = new System.Windows.Forms.Button();
            this.Button_Number = new System.Windows.Forms.Button();
            this.Button_Author = new System.Windows.Forms.Button();
            this.DG = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Black;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(2, 3);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(66, 64);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 6;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(145)))), ((int)(((byte)(0)))));
            this.txt_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_search.BackgroundImage")));
            this.txt_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txt_search.ForeColor = System.Drawing.Color.Black;
            this.txt_search.Icon = ((System.Drawing.Image)(resources.GetObject("txt_search.Icon")));
            this.txt_search.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txt_search.Location = new System.Drawing.Point(312, 111);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(274, 42);
            this.txt_search.TabIndex = 4;
            this.txt_search.text = "";
            this.txt_search.OnTextChange += new System.EventHandler(this.bunifuTextbox1_OnTextChange);
            this.txt_search.Click += new System.EventHandler(this.bunifuTextbox1_Click);
            this.txt_search.Enter += new System.EventHandler(this.bunifuTextbox1_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::YemenLibrary.Properties.Resources.search2;
            this.pictureBox1.Location = new System.Drawing.Point(309, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.Button_Name);
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Controls.Add(this.Button_Gnre);
            this.bunifuGradientPanel1.Controls.Add(this.Button_Number);
            this.bunifuGradientPanel1.Controls.Add(this.Button_Author);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(2, 186);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(910, 71);
            this.bunifuGradientPanel1.TabIndex = 2;
            this.bunifuGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel1_Paint);
            // 
            // Button_Name
            // 
            this.Button_Name.BackColor = System.Drawing.Color.Black;
            this.Button_Name.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.Button_Name.ForeColor = System.Drawing.Color.White;
            this.Button_Name.Location = new System.Drawing.Point(228, 17);
            this.Button_Name.Name = "Button_Name";
            this.Button_Name.Size = new System.Drawing.Size(90, 40);
            this.Button_Name.TabIndex = 8;
            this.Button_Name.Text = "Name";
            this.Button_Name.UseVisualStyleBackColor = false;
            this.Button_Name.Click += new System.EventHandler(this.Button_Name_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 13F);
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "You can search by :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Button_Gnre
            // 
            this.Button_Gnre.BackColor = System.Drawing.Color.Black;
            this.Button_Gnre.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.Button_Gnre.ForeColor = System.Drawing.Color.White;
            this.Button_Gnre.Location = new System.Drawing.Point(738, 21);
            this.Button_Gnre.Name = "Button_Gnre";
            this.Button_Gnre.Size = new System.Drawing.Size(90, 40);
            this.Button_Gnre.TabIndex = 7;
            this.Button_Gnre.Text = "Genre";
            this.Button_Gnre.UseVisualStyleBackColor = false;
            this.Button_Gnre.Click += new System.EventHandler(this.Button_Genre_Click);
            // 
            // Button_Number
            // 
            this.Button_Number.BackColor = System.Drawing.Color.Black;
            this.Button_Number.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.Button_Number.ForeColor = System.Drawing.Color.White;
            this.Button_Number.Location = new System.Drawing.Point(562, 21);
            this.Button_Number.Name = "Button_Number";
            this.Button_Number.Size = new System.Drawing.Size(90, 40);
            this.Button_Number.TabIndex = 6;
            this.Button_Number.Text = "Number";
            this.Button_Number.UseVisualStyleBackColor = false;
            this.Button_Number.Click += new System.EventHandler(this.Button_Number_Click);
            // 
            // Button_Author
            // 
            this.Button_Author.BackColor = System.Drawing.Color.Black;
            this.Button_Author.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.Button_Author.ForeColor = System.Drawing.Color.White;
            this.Button_Author.Location = new System.Drawing.Point(395, 21);
            this.Button_Author.Name = "Button_Author";
            this.Button_Author.Size = new System.Drawing.Size(90, 40);
            this.Button_Author.TabIndex = 4;
            this.Button_Author.Text = "Author";
            this.Button_Author.UseVisualStyleBackColor = false;
            this.Button_Author.Click += new System.EventHandler(this.Button_Author_Click_1);
            // 
            // DG
            // 
            this.DG.AllowUserToAddRows = false;
            this.DG.AllowUserToResizeColumns = false;
            this.DG.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DG.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DG.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DG.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.DG.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.DG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(145)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG.DoubleBuffered = true;
            this.DG.EnableHeadersVisualStyles = false;
            this.DG.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(145)))), ((int)(((byte)(0)))));
            this.DG.HeaderForeColor = System.Drawing.Color.Black;
            this.DG.Location = new System.Drawing.Point(93, 301);
            this.DG.Name = "DG";
            this.DG.ReadOnly = true;
            this.DG.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DG.RowHeadersVisible = false;
            this.DG.Size = new System.Drawing.Size(695, 233);
            this.DG.TabIndex = 7;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.Gold;
            this.lineShape1.BorderWidth = 4;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 24;
            this.lineShape1.X2 = 889;
            this.lineShape1.Y1 = 283;
            this.lineShape1.Y2 = 283;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(913, 566);
            this.shapeContainer1.TabIndex = 8;
            this.shapeContainer1.TabStop = false;
            // 
            // Search
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(913, 566);
            this.Controls.Add(this.DG);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Button_Author;
        private System.Windows.Forms.Button Button_Number;
        private System.Windows.Forms.Button Button_Gnre;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuTextbox txt_search;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Button Button_Name;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DG;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;

    }
}