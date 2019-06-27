namespace GUI_Application
{
    partial class GUI_Based
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_Based));
            this.drawareapanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_pen = new System.Windows.Forms.Button();
            this.btn_polygon = new System.Windows.Forms.Button();
            this.btn_triangle = new System.Windows.Forms.Button();
            this.btn_elipse = new System.Windows.Forms.Button();
            this.btn_square = new System.Windows.Forms.Button();
            this.btn_Rectangle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.showtexturebox = new System.Windows.Forms.PictureBox();
            this.showcolorbox = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showtexturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showcolorbox)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // drawareapanel
            // 
            this.drawareapanel.BackColor = System.Drawing.Color.White;
            this.drawareapanel.Location = new System.Drawing.Point(94, 155);
            this.drawareapanel.Name = "drawareapanel";
            this.drawareapanel.Size = new System.Drawing.Size(668, 451);
            this.drawareapanel.TabIndex = 1;
            this.drawareapanel.Paint += new System.Windows.Forms.PaintEventHandler(this.drawareapanel_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_pen);
            this.panel3.Controls.Add(this.btn_polygon);
            this.panel3.Controls.Add(this.btn_triangle);
            this.panel3.Controls.Add(this.btn_elipse);
            this.panel3.Controls.Add(this.btn_square);
            this.panel3.Controls.Add(this.btn_Rectangle);
            this.panel3.Location = new System.Drawing.Point(13, 155);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(45, 311);
            this.panel3.TabIndex = 4;
            // 
            // btn_pen
            // 
            this.btn_pen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_pen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_pen.BackgroundImage")));
            this.btn_pen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_pen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_pen.Location = new System.Drawing.Point(6, 3);
            this.btn_pen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_pen.Name = "btn_pen";
            this.btn_pen.Size = new System.Drawing.Size(34, 35);
            this.btn_pen.TabIndex = 7;
            this.btn_pen.UseVisualStyleBackColor = true;
            this.btn_pen.Click += new System.EventHandler(this.btn_pen_Click);
            // 
            // btn_polygon
            // 
            this.btn_polygon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_polygon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_polygon.BackgroundImage")));
            this.btn_polygon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_polygon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_polygon.Location = new System.Drawing.Point(6, 226);
            this.btn_polygon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_polygon.Name = "btn_polygon";
            this.btn_polygon.Size = new System.Drawing.Size(34, 35);
            this.btn_polygon.TabIndex = 6;
            this.btn_polygon.UseVisualStyleBackColor = true;
            this.btn_polygon.Click += new System.EventHandler(this.btn_polygon_Click);
            // 
            // btn_triangle
            // 
            this.btn_triangle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_triangle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_triangle.BackgroundImage")));
            this.btn_triangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_triangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_triangle.Location = new System.Drawing.Point(6, 182);
            this.btn_triangle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_triangle.Name = "btn_triangle";
            this.btn_triangle.Size = new System.Drawing.Size(34, 35);
            this.btn_triangle.TabIndex = 5;
            this.btn_triangle.UseVisualStyleBackColor = true;
            this.btn_triangle.Click += new System.EventHandler(this.btn_triangle_Click);
            // 
            // btn_elipse
            // 
            this.btn_elipse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_elipse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_elipse.BackgroundImage")));
            this.btn_elipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_elipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_elipse.Location = new System.Drawing.Point(6, 137);
            this.btn_elipse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_elipse.Name = "btn_elipse";
            this.btn_elipse.Size = new System.Drawing.Size(34, 35);
            this.btn_elipse.TabIndex = 4;
            this.btn_elipse.UseVisualStyleBackColor = true;
            this.btn_elipse.Click += new System.EventHandler(this.btn_elipse_Click);
            // 
            // btn_square
            // 
            this.btn_square.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_square.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_square.BackgroundImage")));
            this.btn_square.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_square.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_square.Location = new System.Drawing.Point(4, 93);
            this.btn_square.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_square.Name = "btn_square";
            this.btn_square.Size = new System.Drawing.Size(34, 35);
            this.btn_square.TabIndex = 3;
            this.btn_square.UseVisualStyleBackColor = true;
            this.btn_square.Click += new System.EventHandler(this.btn_square_Click);
            // 
            // btn_Rectangle
            // 
            this.btn_Rectangle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Rectangle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Rectangle.BackgroundImage")));
            this.btn_Rectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Rectangle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Rectangle.Location = new System.Drawing.Point(6, 48);
            this.btn_Rectangle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Rectangle.Name = "btn_Rectangle";
            this.btn_Rectangle.Size = new System.Drawing.Size(34, 35);
            this.btn_Rectangle.TabIndex = 2;
            this.btn_Rectangle.UseVisualStyleBackColor = true;
            this.btn_Rectangle.Click += new System.EventHandler(this.btn_Rectangle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Color:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(280, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Texture:";
            // 
            // showtexturebox
            // 
            this.showtexturebox.BackColor = System.Drawing.Color.Black;
            this.showtexturebox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("showtexturebox.BackgroundImage")));
            this.showtexturebox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.showtexturebox.Location = new System.Drawing.Point(401, 95);
            this.showtexturebox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.showtexturebox.Name = "showtexturebox";
            this.showtexturebox.Size = new System.Drawing.Size(32, 32);
            this.showtexturebox.TabIndex = 14;
            this.showtexturebox.TabStop = false;
            this.showtexturebox.Click += new System.EventHandler(this.showtexturebox_Click);
            // 
            // showcolorbox
            // 
            this.showcolorbox.BackColor = System.Drawing.Color.Black;
            this.showcolorbox.Location = new System.Drawing.Point(180, 95);
            this.showcolorbox.Name = "showcolorbox";
            this.showcolorbox.Size = new System.Drawing.Size(39, 32);
            this.showcolorbox.TabIndex = 15;
            this.showcolorbox.TabStop = false;
            this.showcolorbox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(0, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 68);
            this.panel1.TabIndex = 16;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(799, 46);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.BurlyWood;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(75, 42);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openImageToolStripMenuItem,
            this.openTextToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(252, 42);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // openImageToolStripMenuItem
            // 
            this.openImageToolStripMenuItem.Name = "openImageToolStripMenuItem";
            this.openImageToolStripMenuItem.Size = new System.Drawing.Size(266, 42);
            this.openImageToolStripMenuItem.Text = "Open Image";
            this.openImageToolStripMenuItem.Click += new System.EventHandler(this.openImageToolStripMenuItem_Click);
            // 
            // openTextToolStripMenuItem
            // 
            this.openTextToolStripMenuItem.Name = "openTextToolStripMenuItem";
            this.openTextToolStripMenuItem.Size = new System.Drawing.Size(266, 42);
            this.openTextToolStripMenuItem.Text = "Open Text";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveImageToolStripMenuItem,
            this.saveTextToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(252, 42);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveImageToolStripMenuItem
            // 
            this.saveImageToolStripMenuItem.Name = "saveImageToolStripMenuItem";
            this.saveImageToolStripMenuItem.Size = new System.Drawing.Size(257, 42);
            this.saveImageToolStripMenuItem.Text = "Save Image";
            this.saveImageToolStripMenuItem.Click += new System.EventHandler(this.saveImageToolStripMenuItem_Click);
            // 
            // saveTextToolStripMenuItem
            // 
            this.saveTextToolStripMenuItem.Name = "saveTextToolStripMenuItem";
            this.saveTextToolStripMenuItem.Size = new System.Drawing.Size(257, 42);
            this.saveTextToolStripMenuItem.Text = "Save Text";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutUSToolStripMenuItem});
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.BurlyWood;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(90, 42);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutUSToolStripMenuItem
            // 
            this.aboutUSToolStripMenuItem.Name = "aboutUSToolStripMenuItem";
            this.aboutUSToolStripMenuItem.Size = new System.Drawing.Size(252, 42);
            this.aboutUSToolStripMenuItem.Text = "About US";
            // 
            // GUI_Based
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 643);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.showcolorbox);
            this.Controls.Add(this.showtexturebox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.drawareapanel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GUI_Based";
            this.Text = "GUI_Based";
            //this.Load += new System.EventHandler(this.GUI_Based_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.showtexturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showcolorbox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel drawareapanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_pen;
        private System.Windows.Forms.Button btn_polygon;
        private System.Windows.Forms.Button btn_triangle;
        private System.Windows.Forms.Button btn_elipse;
        private System.Windows.Forms.Button btn_square;
        private System.Windows.Forms.Button btn_Rectangle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox showtexturebox;
        private System.Windows.Forms.PictureBox showcolorbox;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUSToolStripMenuItem;
    }
}