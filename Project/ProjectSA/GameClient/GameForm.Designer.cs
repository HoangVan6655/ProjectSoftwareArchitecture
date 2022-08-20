namespace GameClient
{
    partial class GameForm
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
            this.dgvGame = new System.Windows.Forms.DataGridView();
            this.grSearch = new System.Windows.Forms.GroupBox();
            this.lbl_keyword = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxStudio = new System.Windows.Forms.ComboBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lbl_brand = new System.Windows.Forms.Label();
            this.lbl_category = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.grAction = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGame)).BeginInit();
            this.grSearch.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGame
            // 
            this.dgvGame.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGame.Location = new System.Drawing.Point(24, 190);
            this.dgvGame.Margin = new System.Windows.Forms.Padding(6);
            this.dgvGame.Name = "dgvGame";
            this.dgvGame.RowHeadersWidth = 82;
            this.dgvGame.Size = new System.Drawing.Size(1168, 425);
            this.dgvGame.TabIndex = 0;
            this.dgvGame.SelectionChanged += new System.EventHandler(this.dgvGame_SelectionChanged);
            // 
            // grSearch
            // 
            this.grSearch.Controls.Add(this.lbl_keyword);
            this.grSearch.Controls.Add(this.btnSearch);
            this.grSearch.Controls.Add(this.txtKeyword);
            this.grSearch.Location = new System.Drawing.Point(24, 23);
            this.grSearch.Margin = new System.Windows.Forms.Padding(6);
            this.grSearch.Name = "grSearch";
            this.grSearch.Padding = new System.Windows.Forms.Padding(6);
            this.grSearch.Size = new System.Drawing.Size(1166, 133);
            this.grSearch.TabIndex = 1;
            this.grSearch.TabStop = false;
            this.grSearch.Text = "Tìm kiếm Game";
            // 
            // lbl_keyword
            // 
            this.lbl_keyword.AutoSize = true;
            this.lbl_keyword.Location = new System.Drawing.Point(12, 56);
            this.lbl_keyword.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_keyword.Name = "lbl_keyword";
            this.lbl_keyword.Size = new System.Drawing.Size(156, 25);
            this.lbl_keyword.TabIndex = 2;
            this.lbl_keyword.Text = "Nhập Từ Khoá:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1004, 44);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 44);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(184, 50);
            this.txtKeyword.Margin = new System.Windows.Forms.Padding(6);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(804, 31);
            this.txtKeyword.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxStudio);
            this.groupBox1.Controls.Add(this.cbxCategory);
            this.groupBox1.Controls.Add(this.lbl_Price);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.lbl_brand);
            this.groupBox1.Controls.Add(this.lbl_category);
            this.groupBox1.Controls.Add(this.lbl_name);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lbl_ID);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Location = new System.Drawing.Point(24, 644);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(782, 327);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm Game";
            // 
            // cbxStudio
            // 
            this.cbxStudio.FormattingEnabled = true;
            this.cbxStudio.Location = new System.Drawing.Point(184, 203);
            this.cbxStudio.Name = "cbxStudio";
            this.cbxStudio.Size = new System.Drawing.Size(560, 33);
            this.cbxStudio.TabIndex = 12;
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(184, 153);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(560, 33);
            this.cbxCategory.TabIndex = 11;
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Location = new System.Drawing.Point(12, 256);
            this.lbl_Price.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(108, 25);
            this.lbl_Price.TabIndex = 10;
            this.lbl_Price.Text = "Giá Game";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(184, 250);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(6);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(560, 31);
            this.txtPrice.TabIndex = 9;
            // 
            // lbl_brand
            // 
            this.lbl_brand.AutoSize = true;
            this.lbl_brand.Location = new System.Drawing.Point(12, 206);
            this.lbl_brand.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_brand.Name = "lbl_brand";
            this.lbl_brand.Size = new System.Drawing.Size(142, 25);
            this.lbl_brand.TabIndex = 8;
            this.lbl_brand.Text = "Studio Game:";
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Location = new System.Drawing.Point(12, 156);
            this.lbl_category.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(122, 25);
            this.lbl_category.TabIndex = 6;
            this.lbl_category.Text = "Loại Game:";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(12, 106);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(118, 25);
            this.lbl_name.TabIndex = 4;
            this.lbl_name.Text = "Tên Game:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(184, 100);
            this.txtName.Margin = new System.Windows.Forms.Padding(6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(560, 31);
            this.txtName.TabIndex = 3;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(12, 56);
            this.lbl_ID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(111, 25);
            this.lbl_ID.TabIndex = 2;
            this.lbl_ID.Text = "Mã Game:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(184, 50);
            this.txtID.Margin = new System.Windows.Forms.Padding(6);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(560, 31);
            this.txtID.TabIndex = 0;
            // 
            // grAction
            // 
            this.grAction.Controls.Add(this.btnDelete);
            this.grAction.Controls.Add(this.btnUpdate);
            this.grAction.Controls.Add(this.btnAdd);
            this.grAction.Location = new System.Drawing.Point(820, 644);
            this.grAction.Margin = new System.Windows.Forms.Padding(6);
            this.grAction.Name = "grAction";
            this.grAction.Padding = new System.Windows.Forms.Padding(6);
            this.grAction.Size = new System.Drawing.Size(374, 327);
            this.grAction.TabIndex = 4;
            this.grAction.TabStop = false;
            this.grAction.Text = "Hành Động";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(100, 227);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(178, 81);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(100, 127);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(178, 81);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Thay Đổi";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(100, 27);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(178, 81);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 994);
            this.Controls.Add(this.grAction);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grSearch);
            this.Controls.Add(this.dgvGame);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "GameForm";
            this.Text = "Game Form";
            this.Load += new System.EventHandler(this.GameForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGame)).EndInit();
            this.grSearch.ResumeLayout(false);
            this.grSearch.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grAction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGame;
        private System.Windows.Forms.GroupBox grSearch;
        private System.Windows.Forms.Label lbl_keyword;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lbl_brand;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.GroupBox grAction;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbxStudio;
        private System.Windows.Forms.ComboBox cbxCategory;
    }
}