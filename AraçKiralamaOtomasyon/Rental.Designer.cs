namespace AraçKiralamaOtomasyon
{
    partial class Rental
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rental));
            this.feeTxt = new System.Windows.Forms.TextBox();
            this.custNameTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.RentalDataGrid = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label6 = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rentalDate = new DevExpress.XtraEditors.DateEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.returnDate = new DevExpress.XtraEditors.DateEdit();
            this.carplateCb = new System.Windows.Forms.ComboBox();
            this.custIdCb = new System.Windows.Forms.ComboBox();
            this.custSurnameTxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.saveBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RentalDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // feeTxt
            // 
            this.feeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.feeTxt.Location = new System.Drawing.Point(368, 554);
            this.feeTxt.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.feeTxt.Name = "feeTxt";
            this.feeTxt.Size = new System.Drawing.Size(204, 30);
            this.feeTxt.TabIndex = 56;
            // 
            // custNameTxt
            // 
            this.custNameTxt.Enabled = false;
            this.custNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.custNameTxt.Location = new System.Drawing.Point(368, 222);
            this.custNameTxt.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.custNameTxt.Name = "custNameTxt";
            this.custNameTxt.Size = new System.Drawing.Size(204, 30);
            this.custNameTxt.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(149, 560);
            this.label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 25);
            this.label7.TabIndex = 54;
            this.label7.Text = "Harç :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(71, 222);
            this.label8.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 25);
            this.label8.TabIndex = 53;
            this.label8.Text = "Müşteri Adı  :";
            // 
            // RentalDataGrid
            // 
            this.RentalDataGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.RentalDataGrid.Location = new System.Drawing.Point(705, 75);
            this.RentalDataGrid.MainView = this.gridView1;
            this.RentalDataGrid.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.RentalDataGrid.Name = "RentalDataGrid";
            this.RentalDataGrid.Size = new System.Drawing.Size(745, 806);
            this.RentalDataGrid.TabIndex = 52;
            this.RentalDataGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.RentalDataGrid.Click += new System.EventHandler(this.RentalDataGrid_Click);
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 852;
            this.gridView1.GridControl = this.RentalDataGrid;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(780, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(234, 25);
            this.label6.TabIndex = 51;
            this.label6.Text = "Kiralanan Arabalar Listesi";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deleteBtn.Location = new System.Drawing.Point(464, 660);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(174, 55);
            this.deleteBtn.TabIndex = 50;
            this.deleteBtn.Text = "Sil";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.updateBtn.Location = new System.Drawing.Point(258, 660);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(174, 55);
            this.updateBtn.TabIndex = 49;
            this.updateBtn.Text = "Güncelle";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(42, 144);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 25);
            this.label4.TabIndex = 45;
            this.label4.Text = "Müşteri Kimliği :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(54, 62);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 25);
            this.label5.TabIndex = 44;
            this.label5.Text = "Araba Plakası :";
            // 
            // rentalDate
            // 
            this.rentalDate.EditValue = null;
            this.rentalDate.Location = new System.Drawing.Point(368, 390);
            this.rentalDate.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.rentalDate.Name = "rentalDate";
            this.rentalDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rentalDate.Properties.Appearance.Options.UseFont = true;
            this.rentalDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rentalDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rentalDate.Size = new System.Drawing.Size(205, 30);
            this.rentalDate.TabIndex = 58;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(30, 394);
            this.label9.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 25);
            this.label9.TabIndex = 59;
            this.label9.Text = "Kiralama Tarihi  :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(18, 478);
            this.label10.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(180, 25);
            this.label10.TabIndex = 61;
            this.label10.Text = "Geri Dönüş Tarihi  :";
            // 
            // returnDate
            // 
            this.returnDate.EditValue = null;
            this.returnDate.Location = new System.Drawing.Point(368, 471);
            this.returnDate.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.returnDate.Name = "returnDate";
            this.returnDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.returnDate.Properties.Appearance.Options.UseFont = true;
            this.returnDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.returnDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.returnDate.Size = new System.Drawing.Size(205, 30);
            this.returnDate.TabIndex = 60;
            // 
            // carplateCb
            // 
            this.carplateCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.carplateCb.FormattingEnabled = true;
            this.carplateCb.Location = new System.Drawing.Point(368, 52);
            this.carplateCb.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.carplateCb.Name = "carplateCb";
            this.carplateCb.Size = new System.Drawing.Size(204, 33);
            this.carplateCb.TabIndex = 62;
            this.carplateCb.SelectionChangeCommitted += new System.EventHandler(this.carplateCb_SelectionChangeCommitted);
            // 
            // custIdCb
            // 
            this.custIdCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.custIdCb.FormattingEnabled = true;
            this.custIdCb.Location = new System.Drawing.Point(368, 134);
            this.custIdCb.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.custIdCb.Name = "custIdCb";
            this.custIdCb.Size = new System.Drawing.Size(204, 33);
            this.custIdCb.TabIndex = 63;
            this.custIdCb.SelectionChangeCommitted += new System.EventHandler(this.custIdCb_SelectionChangeCommitted);
            // 
            // custSurnameTxt
            // 
            this.custSurnameTxt.Enabled = false;
            this.custSurnameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.custSurnameTxt.Location = new System.Drawing.Point(368, 316);
            this.custSurnameTxt.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.custSurnameTxt.Name = "custSurnameTxt";
            this.custSurnameTxt.Size = new System.Drawing.Size(204, 30);
            this.custSurnameTxt.TabIndex = 65;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(42, 316);
            this.label11.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 25);
            this.label11.TabIndex = 64;
            this.label11.Text = "Müşteri Soyadı :";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(15, 19);
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(684, 869);
            this.xtraTabControl1.TabIndex = 66;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.groupControl1);
            this.xtraTabPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage1.ImageOptions.Image")));
            this.xtraTabPage1.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(682, 823);
            this.xtraTabPage1.Text = "Kiralama Sayfası";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.custIdCb);
            this.groupControl1.Controls.Add(this.custSurnameTxt);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label11);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.saveBtn);
            this.groupControl1.Controls.Add(this.carplateCb);
            this.groupControl1.Controls.Add(this.updateBtn);
            this.groupControl1.Controls.Add(this.label10);
            this.groupControl1.Controls.Add(this.deleteBtn);
            this.groupControl1.Controls.Add(this.returnDate);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.label9);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.rentalDate);
            this.groupControl1.Controls.Add(this.custNameTxt);
            this.groupControl1.Controls.Add(this.feeTxt);
            this.groupControl1.Location = new System.Drawing.Point(8, 4);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(666, 794);
            this.groupControl1.TabIndex = 31;
            this.groupControl1.Text = "groupControl1";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(1648, 15);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(148, 45);
            this.simpleButton1.TabIndex = 67;
            this.simpleButton1.Text = "Geri";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saveBtn.Location = new System.Drawing.Point(42, 660);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(8);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(174, 55);
            this.saveBtn.TabIndex = 48;
            this.saveBtn.Text = "Kaydet";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(1276, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 55);
            this.button1.TabIndex = 68;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Rental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1485, 921);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.RentalDataGrid);
            this.Controls.Add(this.label6);
            this.Name = "Rental";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KiralamaSayfası";
            ((System.ComponentModel.ISupportInitialize)(this.RentalDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox feeTxt;
        private System.Windows.Forms.TextBox custNameTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraGrid.GridControl RentalDataGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.DateEdit rentalDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.DateEdit returnDate;
        private System.Windows.Forms.ComboBox carplateCb;
        private System.Windows.Forms.ComboBox custIdCb;
        private System.Windows.Forms.TextBox custSurnameTxt;
        private System.Windows.Forms.Label label11;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button button1;
    }
}