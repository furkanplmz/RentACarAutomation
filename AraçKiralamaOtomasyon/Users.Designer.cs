namespace AraçKiralamaOtomasyon
{
    partial class Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            this.UserPassTxt = new System.Windows.Forms.TextBox();
            this.UserNameTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.deleteUser = new System.Windows.Forms.Button();
            this.updateUser = new System.Windows.Forms.Button();
            this.kaydetUser = new System.Windows.Forms.Button();
            this.UserdataGrid = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UserdataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserPassTxt
            // 
            this.UserPassTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UserPassTxt.Location = new System.Drawing.Point(251, 162);
            this.UserPassTxt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.UserPassTxt.Name = "UserPassTxt";
            this.UserPassTxt.Size = new System.Drawing.Size(318, 30);
            this.UserPassTxt.TabIndex = 10;
            // 
            // UserNameTxt
            // 
            this.UserNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UserNameTxt.Location = new System.Drawing.Point(251, 95);
            this.UserNameTxt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.UserNameTxt.Name = "UserNameTxt";
            this.UserNameTxt.Size = new System.Drawing.Size(318, 30);
            this.UserNameTxt.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(135, 169);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Şifre :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(51, 101);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Kullanıcı Adı :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(899, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Kullanıcı Listesi";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // deleteUser
            // 
            this.deleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deleteUser.Location = new System.Drawing.Point(482, 298);
            this.deleteUser.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.deleteUser.Name = "deleteUser";
            this.deleteUser.Size = new System.Drawing.Size(161, 48);
            this.deleteUser.TabIndex = 15;
            this.deleteUser.Text = "Sil";
            this.deleteUser.UseVisualStyleBackColor = true;
            this.deleteUser.Click += new System.EventHandler(this.deleteUser_Click);
            // 
            // updateUser
            // 
            this.updateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.updateUser.Location = new System.Drawing.Point(265, 298);
            this.updateUser.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.updateUser.Name = "updateUser";
            this.updateUser.Size = new System.Drawing.Size(161, 48);
            this.updateUser.TabIndex = 14;
            this.updateUser.Text = "Güncelle";
            this.updateUser.UseVisualStyleBackColor = true;
            this.updateUser.Click += new System.EventHandler(this.updateUser_Click);
            // 
            // kaydetUser
            // 
            this.kaydetUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaydetUser.Location = new System.Drawing.Point(48, 298);
            this.kaydetUser.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.kaydetUser.Name = "kaydetUser";
            this.kaydetUser.Size = new System.Drawing.Size(161, 48);
            this.kaydetUser.TabIndex = 13;
            this.kaydetUser.Text = "Kaydet";
            this.kaydetUser.UseVisualStyleBackColor = true;
            this.kaydetUser.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserdataGrid
            // 
            this.UserdataGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.UserdataGrid.Location = new System.Drawing.Point(741, 90);
            this.UserdataGrid.MainView = this.gridView1;
            this.UserdataGrid.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.UserdataGrid.Name = "UserdataGrid";
            this.UserdataGrid.Size = new System.Drawing.Size(960, 425);
            this.UserdataGrid.TabIndex = 16;
            this.UserdataGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.UserdataGrid.Click += new System.EventHandler(this.UserdataGrid_Click);
            this.UserdataGrid.DoubleClick += new System.EventHandler(this.UserdataGrid_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 682;
            this.gridView1.GridControl = this.UserdataGrid;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(2, 24);
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(726, 492);
            this.xtraTabControl1.TabIndex = 91;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.groupControl1);
            this.xtraTabPage1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("xtraTabPage1.ImageOptions.SvgImage")));
            this.xtraTabPage1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(724, 438);
            this.xtraTabPage1.Text = "Kullanıcı Sayfası";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.UserNameTxt);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.deleteUser);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.updateUser);
            this.groupControl1.Controls.Add(this.UserPassTxt);
            this.groupControl1.Controls.Add(this.kaydetUser);
            this.groupControl1.Location = new System.Drawing.Point(6, 6);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(709, 415);
            this.groupControl1.TabIndex = 31;
            this.groupControl1.Text = "groupControl1";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(1296, -3);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 47);
            this.button1.TabIndex = 92;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1477, 549);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.UserdataGrid);
            this.Controls.Add(this.label6);
            this.Name = "Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserdataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
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
        private System.Windows.Forms.TextBox UserPassTxt;
        private System.Windows.Forms.TextBox UserNameTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button deleteUser;
        private System.Windows.Forms.Button updateUser;
        private System.Windows.Forms.Button kaydetUser;
        private DevExpress.XtraGrid.GridControl UserdataGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Button button1;
    }
}