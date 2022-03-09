
namespace _022203TODOリスト
{
    partial class ALL_DATA
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toDoDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new _022203TODOリスト.DataSet1();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.編集履歴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dATAIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naiyouDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.simekiriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tourokubiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete_FLG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDoDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dATAIDDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.naiyouDataGridViewTextBoxColumn,
            this.simekiriDataGridViewTextBoxColumn,
            this.tourokubiDataGridViewTextBoxColumn,
            this.Delete_FLG});
            this.dataGridView1.DataSource = this.toDoDataTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(800, 414);
            this.dataGridView1.TabIndex = 1;
            // 
            // toDoDataTableBindingSource
            // 
            this.toDoDataTableBindingSource.DataMember = "ToDoDataTable";
            this.toDoDataTableBindingSource.DataSource = this.dataSet11;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.編集履歴ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 編集履歴ToolStripMenuItem
            // 
            this.編集履歴ToolStripMenuItem.Name = "編集履歴ToolStripMenuItem";
            this.編集履歴ToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.編集履歴ToolStripMenuItem.Text = "戻す";
            this.編集履歴ToolStripMenuItem.Click += new System.EventHandler(this.編集履歴ToolStripMenuItem_Click);
            // 
            // dATAIDDataGridViewTextBoxColumn
            // 
            this.dATAIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dATAIDDataGridViewTextBoxColumn.DataPropertyName = "DATA_ID";
            this.dATAIDDataGridViewTextBoxColumn.HeaderText = "DATA_ID";
            this.dATAIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dATAIDDataGridViewTextBoxColumn.Name = "dATAIDDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
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
            // tourokubiDataGridViewTextBoxColumn
            // 
            this.tourokubiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tourokubiDataGridViewTextBoxColumn.DataPropertyName = "tourokubi";
            this.tourokubiDataGridViewTextBoxColumn.HeaderText = "tourokubi";
            this.tourokubiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tourokubiDataGridViewTextBoxColumn.Name = "tourokubiDataGridViewTextBoxColumn";
            // 
            // Delete_FLG
            // 
            this.Delete_FLG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Delete_FLG.DataPropertyName = "Delete_FLG";
            this.Delete_FLG.HeaderText = "Delete_FLG";
            this.Delete_FLG.MinimumWidth = 8;
            this.Delete_FLG.Name = "Delete_FLG";
            // 
            // ALL_DATA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ALL_DATA";
            this.Text = "ALL_DATA";
            this.Load += new System.EventHandler(this.ALL_DATA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDoDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fLGDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource toDoDataTableBindingSource;
        private DataSet1 dataSet11;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 編集履歴ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn naiyouDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn simekiriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tourokubiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delete_FLG;
    }
}