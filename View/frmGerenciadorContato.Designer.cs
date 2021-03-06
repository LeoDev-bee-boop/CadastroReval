
namespace CadastroReval.View
{
    partial class frmGerenciadorContato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerenciadorContato));
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.butNovoCliente = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colNOME,
            this.colEMAIL,
            this.colTEL});
            this.dgvCliente.Location = new System.Drawing.Point(12, 43);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.RowHeadersVisible = false;
            this.dgvCliente.RowTemplate.Height = 25;
            this.dgvCliente.Size = new System.Drawing.Size(776, 395);
            this.dgvCliente.TabIndex = 0;
            this.dgvCliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellDoubleClick);
            // 
            // colID
            // 
            this.colID.DataPropertyName = "IdCliente";
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Visible = false;
            // 
            // colNOME
            // 
            this.colNOME.DataPropertyName = "NomeCliente";
            this.colNOME.HeaderText = "NOME";
            this.colNOME.Name = "colNOME";
            this.colNOME.ReadOnly = true;
            // 
            // colEMAIL
            // 
            this.colEMAIL.DataPropertyName = "Email";
            this.colEMAIL.HeaderText = "EMAIL";
            this.colEMAIL.Name = "colEMAIL";
            this.colEMAIL.ReadOnly = true;
            // 
            // colTEL
            // 
            this.colTEL.DataPropertyName = "Telefone";
            this.colTEL.HeaderText = "TELEFONE";
            this.colTEL.Name = "colTEL";
            this.colTEL.ReadOnly = true;
            // 
            // butNovoCliente
            // 
            this.butNovoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butNovoCliente.BackColor = System.Drawing.Color.Transparent;
            this.butNovoCliente.BackgroundImage = global::CadastroReval.Properties.Resources.adicionar;
            this.butNovoCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butNovoCliente.FlatAppearance.BorderSize = 0;
            this.butNovoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butNovoCliente.Location = new System.Drawing.Point(763, 12);
            this.butNovoCliente.Name = "butNovoCliente";
            this.butNovoCliente.Size = new System.Drawing.Size(25, 25);
            this.butNovoCliente.TabIndex = 1;
            this.butNovoCliente.UseVisualStyleBackColor = false;
            this.butNovoCliente.Click += new System.EventHandler(this.butNovoCliente_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BackgroundImage = global::CadastroReval.Properties.Resources.refresh;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(732, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(25, 25);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmGerenciadorContato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.butNovoCliente);
            this.Controls.Add(this.dgvCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(300, 160);
            this.Name = "frmGerenciadorContato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de clientes";
            this.Load += new System.EventHandler(this.frmGerenciadorContato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Button butNovoCliente;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTEL;
    }
}