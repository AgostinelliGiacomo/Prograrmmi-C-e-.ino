namespace GiornataCamp
{
    partial class FormMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.list_par = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_carica = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.operazioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_agg = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // list_par
            // 
            this.list_par.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.list_par.GridLines = true;
            this.list_par.Location = new System.Drawing.Point(19, 28);
            this.list_par.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.list_par.Name = "list_par";
            this.list_par.Size = new System.Drawing.Size(398, 216);
            this.list_par.TabIndex = 0;
            this.list_par.UseCompatibleStateImageBehavior = false;
            this.list_par.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "N";
            this.columnHeader1.Width = 36;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Squadra 1";
            this.columnHeader2.Width = 93;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Squadra 2";
            this.columnHeader3.Width = 94;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Goal 1";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Goal 2";
            // 
            // btn_carica
            // 
            this.btn_carica.Location = new System.Drawing.Point(19, 252);
            this.btn_carica.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_carica.Name = "btn_carica";
            this.btn_carica.Size = new System.Drawing.Size(155, 25);
            this.btn_carica.TabIndex = 1;
            this.btn_carica.Text = "Carica partite";
            this.btn_carica.UseVisualStyleBackColor = true;
            this.btn_carica.Click += new System.EventHandler(this.btn_carica_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operazioniToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(471, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // operazioniToolStripMenuItem
            // 
            this.operazioniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_agg});
            this.operazioniToolStripMenuItem.Name = "operazioniToolStripMenuItem";
            this.operazioniToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.operazioniToolStripMenuItem.Text = "&Operazioni";
            // 
            // menu_agg
            // 
            this.menu_agg.Name = "menu_agg";
            this.menu_agg.Size = new System.Drawing.Size(123, 22);
            this.menu_agg.Text = "&Aggiorna";
            this.menu_agg.Click += new System.EventHandler(this.menu_agg_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 288);
            this.Controls.Add(this.btn_carica);
            this.Controls.Add(this.list_par);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView list_par;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btn_carica;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem operazioniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_agg;
    }
}

