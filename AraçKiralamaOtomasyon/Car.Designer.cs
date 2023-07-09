namespace AraçKiralamaOtomasyon
{
    partial class Car
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Car));
            this.carsDataGrid = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label6 = new System.Windows.Forms.Label();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.modelTxt = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.availableCb = new DevExpress.XtraEditors.ComboBoxEdit();
            this.markaTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.plakaNoTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.carsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.availableCb.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // carsDataGrid
            // 
            this.carsDataGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.carsDataGrid.Location = new System.Drawing.Point(630, 112);
            this.carsDataGrid.MainView = this.gridView1;
            this.carsDataGrid.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.carsDataGrid.Name = "carsDataGrid";
            this.carsDataGrid.Size = new System.Drawing.Size(789, 629);
            this.carsDataGrid.TabIndex = 24;
            this.carsDataGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.carsDataGrid.Click += new System.EventHandler(this.carsDataGrid_Click);
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 852;
            this.gridView1.GridControl = this.carsDataGrid;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(955, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "Araba Listesi";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 16);
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(615, 725);
            this.xtraTabControl1.TabIndex = 31;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.groupControl1);
            this.xtraTabPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage1.ImageOptions.Image")));
            this.xtraTabPage1.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(613, 647);
            this.xtraTabPage1.Text = "Araba Sayfası";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.deleteBtn);
            this.groupControl1.Controls.Add(this.updateBtn);
            this.groupControl1.Controls.Add(this.modelTxt);
            this.groupControl1.Controls.Add(this.saveBtn);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.availableCb);
            this.groupControl1.Controls.Add(this.markaTxt);
            this.groupControl1.Controls.Add(this.label9);
            this.groupControl1.Controls.Add(this.priceTxt);
            this.groupControl1.Controls.Add(this.plakaNoTxt);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Location = new System.Drawing.Point(8, 8);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(600, 612);
            this.groupControl1.TabIndex = 31;
            this.groupControl1.Text = "groupControl1";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deleteBtn.Location = new System.Drawing.Point(444, 456);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(135, 55);
            this.deleteBtn.TabIndex = 39;
            this.deleteBtn.Text = "Sil";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click_1);
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.updateBtn.Location = new System.Drawing.Point(224, 456);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(135, 55);
            this.updateBtn.TabIndex = 38;
            this.updateBtn.Text = "Güncelle";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click_1);
            // 
            // modelTxt
            // 
            this.modelTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.modelTxt.Location = new System.Drawing.Point(244, 172);
            this.modelTxt.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.modelTxt.Name = "modelTxt";
            this.modelTxt.Size = new System.Drawing.Size(232, 30);
            this.modelTxt.TabIndex = 42;
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saveBtn.Location = new System.Drawing.Point(39, 456);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(135, 55);
            this.saveBtn.TabIndex = 37;
            this.saveBtn.Text = "Kaydet";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(10, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 25);
            this.label5.TabIndex = 33;
            this.label5.Text = "Plaka Numarası :";
            // 
            // availableCb
            // 
            this.availableCb.Location = new System.Drawing.Point(244, 341);
            this.availableCb.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.availableCb.Name = "availableCb";
            this.availableCb.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.availableCb.Properties.Appearance.Options.UseFont = true;
            this.availableCb.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.availableCb.Properties.Items.AddRange(new object[] {
            "Evet",
            "Hayır"});
            this.availableCb.Size = new System.Drawing.Size(232, 30);
            this.availableCb.TabIndex = 44;
            // 
            // markaTxt
            // 
            this.markaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.markaTxt.Location = new System.Drawing.Point(244, 90);
            this.markaTxt.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.markaTxt.Name = "markaTxt";
            this.markaTxt.Size = new System.Drawing.Size(232, 30);
            this.markaTxt.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(20, 348);
            this.label9.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 25);
            this.label9.TabIndex = 45;
            this.label9.Text = "Kullanılabilir Mi :";
            // 
            // priceTxt
            // 
            this.priceTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.priceTxt.Location = new System.Drawing.Point(244, 254);
            this.priceTxt.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(232, 30);
            this.priceTxt.TabIndex = 43;
            // 
            // plakaNoTxt
            // 
            this.plakaNoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.plakaNoTxt.Location = new System.Drawing.Point(244, 15);
            this.plakaNoTxt.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.plakaNoTxt.Name = "plakaNoTxt";
            this.plakaNoTxt.Size = new System.Drawing.Size(232, 30);
            this.plakaNoTxt.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(124, 260);
            this.label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 25);
            this.label7.TabIndex = 41;
            this.label7.Text = "Ücret :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(112, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 34;
            this.label4.Text = "Marka :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(108, 179);
            this.label8.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 25);
            this.label8.TabIndex = 40;
            this.label8.Text = "Model  :";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(1271, 2);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(148, 45);
            this.simpleButton1.TabIndex = 32;
            this.simpleButton1.Text = "Geri";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Car
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1461, 674);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.carsDataGrid);
            this.Controls.Add(this.label6);
            this.Name = "Car";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car";
            ((System.ComponentModel.ISupportInitialize)(this.carsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.availableCb.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl carsDataGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.TextBox modelTxt;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.ComboBoxEdit availableCb;
        private System.Windows.Forms.TextBox markaTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox priceTxt;
        private System.Windows.Forms.TextBox plakaNoTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
    }
}