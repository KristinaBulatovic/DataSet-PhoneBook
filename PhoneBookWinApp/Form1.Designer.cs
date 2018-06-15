namespace PhoneBookWinApp
{
    partial class Form1
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
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastnameLabel;
            System.Windows.Forms.Label telephone_NumberLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataDirectoryBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.dataDirectoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phoneBookDataSet = new PhoneBookWinApp.PhoneBookDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dataDirectoryBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dataDirectoryDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.lastnameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.telephone_NumberTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dataDirectoryTableAdapter = new PhoneBookWinApp.PhoneBookDataSetTableAdapters.DataDirectoryTableAdapter();
            this.tableAdapterManager = new PhoneBookWinApp.PhoneBookDataSetTableAdapters.TableAdapterManager();
            firstNameLabel = new System.Windows.Forms.Label();
            lastnameLabel = new System.Windows.Forms.Label();
            telephone_NumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataDirectoryBindingNavigator)).BeginInit();
            this.dataDirectoryBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDirectoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBookDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDirectoryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastnameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telephone_NumberTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(481, 185);
            firstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(85, 19);
            firstNameLabel.TabIndex = 4;
            firstNameLabel.Text = "First Name:";
            // 
            // lastnameLabel
            // 
            lastnameLabel.AutoSize = true;
            lastnameLabel.Location = new System.Drawing.Point(481, 223);
            lastnameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lastnameLabel.Name = "lastnameLabel";
            lastnameLabel.Size = new System.Drawing.Size(78, 19);
            lastnameLabel.TabIndex = 6;
            lastnameLabel.Text = "Lastname:";
            // 
            // telephone_NumberLabel
            // 
            telephone_NumberLabel.AutoSize = true;
            telephone_NumberLabel.Location = new System.Drawing.Point(481, 261);
            telephone_NumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            telephone_NumberLabel.Name = "telephone_NumberLabel";
            telephone_NumberLabel.Size = new System.Drawing.Size(137, 19);
            telephone_NumberLabel.TabIndex = 8;
            telephone_NumberLabel.Text = "Telephone Number:";
            // 
            // dataDirectoryBindingNavigator
            // 
            this.dataDirectoryBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dataDirectoryBindingNavigator.BindingSource = this.dataDirectoryBindingSource;
            this.dataDirectoryBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dataDirectoryBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.dataDirectoryBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.dataDirectoryBindingNavigatorSaveItem});
            this.dataDirectoryBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dataDirectoryBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dataDirectoryBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dataDirectoryBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dataDirectoryBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dataDirectoryBindingNavigator.Name = "dataDirectoryBindingNavigator";
            this.dataDirectoryBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dataDirectoryBindingNavigator.Size = new System.Drawing.Size(796, 25);
            this.dataDirectoryBindingNavigator.TabIndex = 0;
            this.dataDirectoryBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // dataDirectoryBindingSource
            // 
            this.dataDirectoryBindingSource.DataMember = "DataDirectory";
            this.dataDirectoryBindingSource.DataSource = this.phoneBookDataSet;
            // 
            // phoneBookDataSet
            // 
            this.phoneBookDataSet.DataSetName = "PhoneBookDataSet";
            this.phoneBookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // dataDirectoryBindingNavigatorSaveItem
            // 
            this.dataDirectoryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dataDirectoryBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dataDirectoryBindingNavigatorSaveItem.Image")));
            this.dataDirectoryBindingNavigatorSaveItem.Name = "dataDirectoryBindingNavigatorSaveItem";
            this.dataDirectoryBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.dataDirectoryBindingNavigatorSaveItem.Text = "Save Data";
            this.dataDirectoryBindingNavigatorSaveItem.Click += new System.EventHandler(this.dataDirectoryBindingNavigatorSaveItem_Click);
            // 
            // dataDirectoryDataGridView
            // 
            this.dataDirectoryDataGridView.AutoGenerateColumns = false;
            this.dataDirectoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDirectoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataDirectoryDataGridView.DataSource = this.dataDirectoryBindingSource;
            this.dataDirectoryDataGridView.Location = new System.Drawing.Point(13, 45);
            this.dataDirectoryDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataDirectoryDataGridView.Name = "dataDirectoryDataGridView";
            this.dataDirectoryDataGridView.Size = new System.Drawing.Size(443, 289);
            this.dataDirectoryDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn2.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Lastname";
            this.dataGridViewTextBoxColumn3.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Telephone Number";
            this.dataGridViewTextBoxColumn4.HeaderText = "Telephone Number";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // firstNameTextEdit
            // 
            this.firstNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dataDirectoryBindingSource, "FirstName", true));
            this.firstNameTextEdit.Location = new System.Drawing.Point(626, 186);
            this.firstNameTextEdit.Margin = new System.Windows.Forms.Padding(4);
            this.firstNameTextEdit.Name = "firstNameTextEdit";
            this.firstNameTextEdit.Size = new System.Drawing.Size(133, 20);
            this.firstNameTextEdit.TabIndex = 5;
            // 
            // lastnameTextEdit
            // 
            this.lastnameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dataDirectoryBindingSource, "Lastname", true));
            this.lastnameTextEdit.Location = new System.Drawing.Point(626, 224);
            this.lastnameTextEdit.Margin = new System.Windows.Forms.Padding(4);
            this.lastnameTextEdit.Name = "lastnameTextEdit";
            this.lastnameTextEdit.Size = new System.Drawing.Size(133, 20);
            this.lastnameTextEdit.TabIndex = 7;
            // 
            // telephone_NumberTextEdit
            // 
            this.telephone_NumberTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dataDirectoryBindingSource, "Telephone Number", true));
            this.telephone_NumberTextEdit.Location = new System.Drawing.Point(626, 262);
            this.telephone_NumberTextEdit.Margin = new System.Windows.Forms.Padding(4);
            this.telephone_NumberTextEdit.Name = "telephone_NumberTextEdit";
            this.telephone_NumberTextEdit.Size = new System.Drawing.Size(133, 20);
            this.telephone_NumberTextEdit.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(480, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(544, 45);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(215, 26);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dataDirectoryTableAdapter
            // 
            this.dataDirectoryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DataDirectoryTableAdapter = this.dataDirectoryTableAdapter;
            this.tableAdapterManager.UpdateOrder = PhoneBookWinApp.PhoneBookDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 350);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextEdit);
            this.Controls.Add(lastnameLabel);
            this.Controls.Add(this.lastnameTextEdit);
            this.Controls.Add(telephone_NumberLabel);
            this.Controls.Add(this.telephone_NumberTextEdit);
            this.Controls.Add(this.dataDirectoryDataGridView);
            this.Controls.Add(this.dataDirectoryBindingNavigator);
            this.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phone Book";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataDirectoryBindingNavigator)).EndInit();
            this.dataDirectoryBindingNavigator.ResumeLayout(false);
            this.dataDirectoryBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDirectoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBookDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDirectoryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastnameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telephone_NumberTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PhoneBookDataSet phoneBookDataSet;
        private System.Windows.Forms.BindingSource dataDirectoryBindingSource;
        private PhoneBookDataSetTableAdapters.DataDirectoryTableAdapter dataDirectoryTableAdapter;
        private PhoneBookDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator dataDirectoryBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton dataDirectoryBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView dataDirectoryDataGridView;
        private DevExpress.XtraEditors.TextEdit firstNameTextEdit;
        private DevExpress.XtraEditors.TextEdit lastnameTextEdit;
        private DevExpress.XtraEditors.TextEdit telephone_NumberTextEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearch;
    }
}

