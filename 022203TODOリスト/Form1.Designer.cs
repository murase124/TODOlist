
namespace _022203TODOリスト
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toDoDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new _022203TODOリスト.DataSet1();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.登録ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.削除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.編集ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.編集履歴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全てToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naiyouDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.simekiriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDoDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.DATA_ID,
            this.naiyouDataGridViewTextBoxColumn,
            this.simekiriDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.toDoDataTableBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(800, 417);
            this.dataGridView1.TabIndex = 0;
            // 
            // toDoDataTableBindingSource
            // 
            this.toDoDataTableBindingSource.DataMember = "ToDoDataTable";
            this.toDoDataTableBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.登録ToolStripMenuItem,
            this.削除ToolStripMenuItem,
            this.編集ToolStripMenuItem,
            this.更新ToolStripMenuItem,
            this.編集履歴ToolStripMenuItem,
            this.全てToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 登録ToolStripMenuItem
            // 
            this.登録ToolStripMenuItem.Name = "登録ToolStripMenuItem";
            this.登録ToolStripMenuItem.Size = new System.Drawing.Size(64, 29);
            this.登録ToolStripMenuItem.Text = "登録";
            this.登録ToolStripMenuItem.Click += new System.EventHandler(this.登録ToolStripMenuItem_Click);
            // 
            // 削除ToolStripMenuItem
            // 
            this.削除ToolStripMenuItem.Name = "削除ToolStripMenuItem";
            this.削除ToolStripMenuItem.Size = new System.Drawing.Size(64, 29);
            this.削除ToolStripMenuItem.Text = "削除";
            this.削除ToolStripMenuItem.Click += new System.EventHandler(this.削除ToolStripMenuItem_Click);
            // 
            // 編集ToolStripMenuItem
            // 
            this.編集ToolStripMenuItem.Name = "編集ToolStripMenuItem";
            this.編集ToolStripMenuItem.Size = new System.Drawing.Size(64, 29);
            this.編集ToolStripMenuItem.Text = "編集";
            this.編集ToolStripMenuItem.Click += new System.EventHandler(this.編集ToolStripMenuItem_Click);
            // 
            // 更新ToolStripMenuItem
            // 
            this.更新ToolStripMenuItem.Name = "更新ToolStripMenuItem";
            this.更新ToolStripMenuItem.Size = new System.Drawing.Size(64, 29);
            this.更新ToolStripMenuItem.Text = "更新";
            this.更新ToolStripMenuItem.Click += new System.EventHandler(this.更新ToolStripMenuItem_Click);
            // 
            // 編集履歴ToolStripMenuItem
            // 
            this.編集履歴ToolStripMenuItem.Name = "編集履歴ToolStripMenuItem";
            this.編集履歴ToolStripMenuItem.Size = new System.Drawing.Size(100, 29);
            this.編集履歴ToolStripMenuItem.Text = "編集履歴";
            this.編集履歴ToolStripMenuItem.Click += new System.EventHandler(this.編集履歴ToolStripMenuItem_Click);
            // 
            // 全てToolStripMenuItem
            // 
            this.全てToolStripMenuItem.Name = "全てToolStripMenuItem";
            this.全てToolStripMenuItem.Size = new System.Drawing.Size(59, 29);
            this.全てToolStripMenuItem.Text = "全て";
            this.全てToolStripMenuItem.Click += new System.EventHandler(this.全てToolStripMenuItem_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 57;
            // 
            // DATA_ID
            // 
            this.DATA_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DATA_ID.DataPropertyName = "DATA_ID";
            this.DATA_ID.HeaderText = "DATA_ID";
            this.DATA_ID.MinimumWidth = 8;
            this.DATA_ID.Name = "DATA_ID";
            this.DATA_ID.Width = 110;
            // 
            // naiyouDataGridViewTextBoxColumn
            // 
            this.naiyouDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.naiyouDataGridViewTextBoxColumn.DataPropertyName = "naiyou";
            this.naiyouDataGridViewTextBoxColumn.HeaderText = "naiyou";
            this.naiyouDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.naiyouDataGridViewTextBoxColumn.Name = "naiyouDataGridViewTextBoxColumn";
            // 
            // simekiriDataGridViewTextBoxColumn
            // 
            this.simekiriDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.simekiriDataGridViewTextBoxColumn.DataPropertyName = "simekiri";
            this.simekiriDataGridViewTextBoxColumn.HeaderText = "simekiri";
            this.simekiriDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.simekiriDataGridViewTextBoxColumn.Name = "simekiriDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDoDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 登録ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 削除ToolStripMenuItem;
        private System.Windows.Forms.BindingSource toDoDataTableBindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.ToolStripMenuItem 編集ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 更新ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 編集履歴ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全てToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn naiyouDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn simekiriDataGridViewTextBoxColumn;
    }
}

