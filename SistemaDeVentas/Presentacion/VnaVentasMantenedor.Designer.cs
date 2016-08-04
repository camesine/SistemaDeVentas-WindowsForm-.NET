namespace SistemaDeVentas.Presentacion
{
    partial class VnaVentasMantenedor
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
            System.Windows.Forms.Label idventaLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label netoLabel;
            System.Windows.Forms.Label ivaLabel;
            System.Windows.Forms.Label totalLabel;
            System.Windows.Forms.Label condicionesLabel;
            System.Windows.Forms.Label cod_clienteLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VnaVentasMantenedor));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ventaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.ventaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDTiendaDataSet = new SistemaDeVentas.BDTiendaDataSet();
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
            this.ventaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.ventaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idventaTextBox = new System.Windows.Forms.TextBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.netoTextBox = new System.Windows.Forms.TextBox();
            this.ivaTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.condicionesTextBox = new System.Windows.Forms.TextBox();
            this.cod_clienteTextBox = new System.Windows.Forms.TextBox();
            this.ventaTableAdapter = new SistemaDeVentas.BDTiendaDataSetTableAdapters.ventaTableAdapter();
            this.tableAdapterManager = new SistemaDeVentas.BDTiendaDataSetTableAdapters.TableAdapterManager();
            idventaLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            netoLabel = new System.Windows.Forms.Label();
            ivaLabel = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            condicionesLabel = new System.Windows.Forms.Label();
            cod_clienteLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingNavigator)).BeginInit();
            this.ventaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDTiendaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idventaLabel
            // 
            idventaLabel.AutoSize = true;
            idventaLabel.Location = new System.Drawing.Point(132, 20);
            idventaLabel.Name = "idventaLabel";
            idventaLabel.Size = new System.Drawing.Size(47, 13);
            idventaLabel.TabIndex = 0;
            idventaLabel.Text = "Id Venta";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(132, 47);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(37, 13);
            fechaLabel.TabIndex = 2;
            fechaLabel.Text = "Fecha";
            // 
            // netoLabel
            // 
            netoLabel.AutoSize = true;
            netoLabel.Location = new System.Drawing.Point(132, 72);
            netoLabel.Name = "netoLabel";
            netoLabel.Size = new System.Drawing.Size(30, 13);
            netoLabel.TabIndex = 4;
            netoLabel.Text = "Neto";
            // 
            // ivaLabel
            // 
            ivaLabel.AutoSize = true;
            ivaLabel.Location = new System.Drawing.Point(132, 98);
            ivaLabel.Name = "ivaLabel";
            ivaLabel.Size = new System.Drawing.Size(22, 13);
            ivaLabel.TabIndex = 6;
            ivaLabel.Text = "Iva";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new System.Drawing.Point(472, 21);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(31, 13);
            totalLabel.TabIndex = 8;
            totalLabel.Text = "Total";
            // 
            // condicionesLabel
            // 
            condicionesLabel.AutoSize = true;
            condicionesLabel.Location = new System.Drawing.Point(472, 47);
            condicionesLabel.Name = "condicionesLabel";
            condicionesLabel.Size = new System.Drawing.Size(65, 13);
            condicionesLabel.TabIndex = 10;
            condicionesLabel.Text = "Condiciones";
            // 
            // cod_clienteLabel
            // 
            cod_clienteLabel.AutoSize = true;
            cod_clienteLabel.Location = new System.Drawing.Point(472, 73);
            cod_clienteLabel.Name = "cod_clienteLabel";
            cod_clienteLabel.Size = new System.Drawing.Size(64, 13);
            cod_clienteLabel.TabIndex = 12;
            cod_clienteLabel.Text = "Cod_Cliente";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtBuscar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ventaBindingNavigator);
            this.groupBox1.Controls.Add(this.ventaDataGridView);
            this.groupBox1.Controls.Add(idventaLabel);
            this.groupBox1.Controls.Add(this.idventaTextBox);
            this.groupBox1.Controls.Add(fechaLabel);
            this.groupBox1.Controls.Add(this.fechaDateTimePicker);
            this.groupBox1.Controls.Add(netoLabel);
            this.groupBox1.Controls.Add(this.netoTextBox);
            this.groupBox1.Controls.Add(ivaLabel);
            this.groupBox1.Controls.Add(this.ivaTextBox);
            this.groupBox1.Controls.Add(totalLabel);
            this.groupBox1.Controls.Add(this.totalTextBox);
            this.groupBox1.Controls.Add(condicionesLabel);
            this.groupBox1.Controls.Add(this.condicionesTextBox);
            this.groupBox1.Controls.Add(cod_clienteLabel);
            this.groupBox1.Controls.Add(this.cod_clienteTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(882, 388);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MANTENEDOR DE VENTAS";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(597, 357);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(100, 20);
            this.TxtBuscar.TabIndex = 16;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(519, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Filtro Id Venta";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ventaBindingNavigator
            // 
            this.ventaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ventaBindingNavigator.BindingSource = this.ventaBindingSource;
            this.ventaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ventaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ventaBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.ventaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.ventaBindingNavigatorSaveItem});
            this.ventaBindingNavigator.Location = new System.Drawing.Point(76, 353);
            this.ventaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ventaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ventaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ventaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ventaBindingNavigator.Name = "ventaBindingNavigator";
            this.ventaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ventaBindingNavigator.Size = new System.Drawing.Size(278, 25);
            this.ventaBindingNavigator.TabIndex = 1;
            this.ventaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // ventaBindingSource
            // 
            this.ventaBindingSource.DataMember = "venta";
            this.ventaBindingSource.DataSource = this.bDTiendaDataSet;
            // 
            // bDTiendaDataSet
            // 
            this.bDTiendaDataSet.DataSetName = "BDTiendaDataSet";
            this.bDTiendaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 22);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
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
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // ventaBindingNavigatorSaveItem
            // 
            this.ventaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ventaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ventaBindingNavigatorSaveItem.Image")));
            this.ventaBindingNavigatorSaveItem.Name = "ventaBindingNavigatorSaveItem";
            this.ventaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.ventaBindingNavigatorSaveItem.Text = "Guardar datos";
            this.ventaBindingNavigatorSaveItem.Click += new System.EventHandler(this.ventaBindingNavigatorSaveItem_Click);
            // 
            // ventaDataGridView
            // 
            this.ventaDataGridView.AutoGenerateColumns = false;
            this.ventaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ventaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.ventaDataGridView.DataSource = this.ventaBindingSource;
            this.ventaDataGridView.Location = new System.Drawing.Point(76, 130);
            this.ventaDataGridView.Name = "ventaDataGridView";
            this.ventaDataGridView.Size = new System.Drawing.Size(744, 220);
            this.ventaDataGridView.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idventa";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID VENTA";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "fecha";
            this.dataGridViewTextBoxColumn2.HeaderText = "FECHA";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "neto";
            this.dataGridViewTextBoxColumn3.HeaderText = "NETO";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "iva";
            this.dataGridViewTextBoxColumn4.HeaderText = "IVA";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "total";
            this.dataGridViewTextBoxColumn5.HeaderText = "TOTAL";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "condiciones";
            this.dataGridViewTextBoxColumn6.HeaderText = "CONDICIONES";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "cod_cliente";
            this.dataGridViewTextBoxColumn7.HeaderText = "CODIGO CLIENTE";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // idventaTextBox
            // 
            this.idventaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventaBindingSource, "idventa", true));
            this.idventaTextBox.Location = new System.Drawing.Point(205, 17);
            this.idventaTextBox.Name = "idventaTextBox";
            this.idventaTextBox.Size = new System.Drawing.Size(200, 20);
            this.idventaTextBox.TabIndex = 1;
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ventaBindingSource, "fecha", true));
            this.fechaDateTimePicker.Location = new System.Drawing.Point(205, 43);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaDateTimePicker.TabIndex = 3;
            // 
            // netoTextBox
            // 
            this.netoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventaBindingSource, "neto", true));
            this.netoTextBox.Location = new System.Drawing.Point(205, 69);
            this.netoTextBox.Name = "netoTextBox";
            this.netoTextBox.Size = new System.Drawing.Size(200, 20);
            this.netoTextBox.TabIndex = 5;
            // 
            // ivaTextBox
            // 
            this.ivaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventaBindingSource, "iva", true));
            this.ivaTextBox.Location = new System.Drawing.Point(205, 95);
            this.ivaTextBox.Name = "ivaTextBox";
            this.ivaTextBox.Size = new System.Drawing.Size(200, 20);
            this.ivaTextBox.TabIndex = 7;
            // 
            // totalTextBox
            // 
            this.totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventaBindingSource, "total", true));
            this.totalTextBox.Location = new System.Drawing.Point(545, 18);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(200, 20);
            this.totalTextBox.TabIndex = 9;
            // 
            // condicionesTextBox
            // 
            this.condicionesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventaBindingSource, "condiciones", true));
            this.condicionesTextBox.Location = new System.Drawing.Point(545, 44);
            this.condicionesTextBox.Name = "condicionesTextBox";
            this.condicionesTextBox.Size = new System.Drawing.Size(200, 20);
            this.condicionesTextBox.TabIndex = 11;
            // 
            // cod_clienteTextBox
            // 
            this.cod_clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventaBindingSource, "cod_cliente", true));
            this.cod_clienteTextBox.Location = new System.Drawing.Point(545, 70);
            this.cod_clienteTextBox.Name = "cod_clienteTextBox";
            this.cod_clienteTextBox.Size = new System.Drawing.Size(200, 20);
            this.cod_clienteTextBox.TabIndex = 13;
            // 
            // ventaTableAdapter
            // 
            this.ventaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.DetalleTableAdapter = null;
            this.tableAdapterManager.ProductoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SistemaDeVentas.BDTiendaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ventaTableAdapter = this.ventaTableAdapter;
            // 
            // VnaVentasMantenedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 412);
            this.Controls.Add(this.groupBox1);
            this.Name = "VnaVentasMantenedor";
            this.Text = "VnaVentasMantenedor";
            this.Load += new System.EventHandler(this.VnaVentasMantenedor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingNavigator)).EndInit();
            this.ventaBindingNavigator.ResumeLayout(false);
            this.ventaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDTiendaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private BDTiendaDataSet bDTiendaDataSet;
        private System.Windows.Forms.BindingSource ventaBindingSource;
        private BDTiendaDataSetTableAdapters.ventaTableAdapter ventaTableAdapter;
        private BDTiendaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ventaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton ventaBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idventaTextBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.TextBox netoTextBox;
        private System.Windows.Forms.TextBox ivaTextBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.TextBox condicionesTextBox;
        private System.Windows.Forms.TextBox cod_clienteTextBox;
        private System.Windows.Forms.DataGridView ventaDataGridView;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}