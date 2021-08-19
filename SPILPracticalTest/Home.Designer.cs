
namespace SPILPracticalTest
{
    partial class Home
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
            this.plHome = new System.Windows.Forms.Panel();
            this.dgvHomeView = new System.Windows.Forms.DataGridView();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.plHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHomeView)).BeginInit();
            this.SuspendLayout();
            // 
            // plHome
            // 
            this.plHome.Controls.Add(this.dgvHomeView);
            this.plHome.Controls.Add(this.btnAddNew);
            this.plHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plHome.Location = new System.Drawing.Point(0, 0);
            this.plHome.Name = "plHome";
            this.plHome.Size = new System.Drawing.Size(770, 496);
            this.plHome.TabIndex = 0;
            this.plHome.Paint += new System.Windows.Forms.PaintEventHandler(this.plHome_Paint);
            // 
            // dgvHomeView
            // 
            this.dgvHomeView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHomeView.Location = new System.Drawing.Point(12, 79);
            this.dgvHomeView.Name = "dgvHomeView";
            this.dgvHomeView.RowTemplate.Height = 24;
            this.dgvHomeView.Size = new System.Drawing.Size(746, 405);
            this.dgvHomeView.TabIndex = 1;
            this.dgvHomeView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvHomeView_MouseDoubleClick);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(22, 12);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(93, 29);
            this.btnAddNew.TabIndex = 0;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 496);
            this.Controls.Add(this.plHome);
            this.MaximizeBox = false;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.plHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHomeView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plHome;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.DataGridView dgvHomeView;
    }
}