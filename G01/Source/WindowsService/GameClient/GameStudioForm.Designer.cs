namespace GameClient
{
    partial class GameStudioForm
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
            this.dgvStudio = new System.Windows.Forms.DataGridView();
            this.grSearch = new System.Windows.Forms.GroupBox();
            this.lbl_keyword = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.grAction = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbl_studiogame = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudio)).BeginInit();
            this.grSearch.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStudio
            // 
            this.dgvStudio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudio.Location = new System.Drawing.Point(12, 163);
            this.dgvStudio.Name = "dgvStudio";
            this.dgvStudio.RowHeadersWidth = 82;
            this.dgvStudio.Size = new System.Drawing.Size(839, 203);
            this.dgvStudio.TabIndex = 0;
            this.dgvStudio.SelectionChanged += new System.EventHandler(this.dgvStudio_SelectionChanged);
            // 
            // grSearch
            // 
            this.grSearch.Controls.Add(this.lbl_keyword);
            this.grSearch.Controls.Add(this.btnSearch);
            this.grSearch.Controls.Add(this.txtKeyword);
            this.grSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grSearch.Location = new System.Drawing.Point(56, 58);
            this.grSearch.Name = "grSearch";
            this.grSearch.Size = new System.Drawing.Size(747, 81);
            this.grSearch.TabIndex = 1;
            this.grSearch.TabStop = false;
            this.grSearch.Text = "Tìm kiếm Studio Game";
            // 
            // lbl_keyword
            // 
            this.lbl_keyword.AutoSize = true;
            this.lbl_keyword.Location = new System.Drawing.Point(27, 29);
            this.lbl_keyword.Name = "lbl_keyword";
            this.lbl_keyword.Size = new System.Drawing.Size(104, 17);
            this.lbl_keyword.TabIndex = 2;
            this.lbl_keyword.Text = "Nhập Từ Khoá:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(610, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 34);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(190, 26);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(366, 23);
            this.txtKeyword.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_name);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lbl_ID);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 401);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(554, 201);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Xem chi tiết Studio Game";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(29, 136);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(123, 17);
            this.lbl_name.TabIndex = 4;
            this.lbl_name.Text = "Tên Studio Game:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(190, 130);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(262, 23);
            this.txtName.TabIndex = 3;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(29, 50);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(117, 17);
            this.lbl_ID.TabIndex = 2;
            this.lbl_ID.Text = "Mã Studio Game:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(190, 50);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(262, 23);
            this.txtID.TabIndex = 0;
            // 
            // grAction
            // 
            this.grAction.Controls.Add(this.btnDelete);
            this.grAction.Controls.Add(this.btnUpdate);
            this.grAction.Controls.Add(this.btnAdd);
            this.grAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grAction.Location = new System.Drawing.Point(664, 401);
            this.grAction.Name = "grAction";
            this.grAction.Size = new System.Drawing.Size(187, 219);
            this.grAction.TabIndex = 4;
            this.grAction.TabStop = false;
            this.grAction.Text = "Hành Động";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(50, 156);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 31);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(50, 93);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(89, 31);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Thay Đổi";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(50, 36);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 31);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbl_studiogame
            // 
            this.lbl_studiogame.AutoSize = true;
            this.lbl_studiogame.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_studiogame.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_studiogame.Location = new System.Drawing.Point(277, 9);
            this.lbl_studiogame.Name = "lbl_studiogame";
            this.lbl_studiogame.Size = new System.Drawing.Size(299, 46);
            this.lbl_studiogame.TabIndex = 5;
            this.lbl_studiogame.Text = "STUDIO GAME";
            // 
            // GameStudioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 647);
            this.Controls.Add(this.lbl_studiogame);
            this.Controls.Add(this.grAction);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grSearch);
            this.Controls.Add(this.dgvStudio);
            this.Name = "GameStudioForm";
            this.Text = "Studio Game Form";
            this.Load += new System.EventHandler(this.GameStudioForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudio)).EndInit();
            this.grSearch.ResumeLayout(false);
            this.grSearch.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grAction.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudio;
        private System.Windows.Forms.GroupBox grSearch;
        private System.Windows.Forms.Label lbl_keyword;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.GroupBox grAction;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lbl_studiogame;
    }
}