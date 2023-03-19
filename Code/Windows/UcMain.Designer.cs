namespace FrmLittleGame;

partial class UcMain
{
  /// <summary> 
  /// Erforderliche Designervariable.
  /// </summary>
  private System.ComponentModel.IContainer components = null;

  /// <summary> 
  /// Verwendete Ressourcen bereinigen.
  /// </summary>
  /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
  protected override void Dispose(bool disposing)
  {
    if (disposing && (components != null))
    {
      components.Dispose();
    }
    base.Dispose(disposing);
  }

  #region Vom Komponenten-Designer generierter Code

  /// <summary> 
  /// Erforderliche Methode für die Designerunterstützung. 
  /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
  /// </summary>
  private void InitializeComponent()
  {
            this.TblUcMain = new System.Windows.Forms.TableLayoutPanel();
            this.PtMain = new System.Windows.Forms.Panel();
            this.DgvMain = new System.Windows.Forms.DataGridView();
            this.TblButtons = new System.Windows.Forms.TableLayoutPanel();
            this.BtNo = new System.Windows.Forms.Button();
            this.BtYes = new System.Windows.Forms.Button();
            this.BtStart = new System.Windows.Forms.Button();
            this.TblUcMain.SuspendLayout();
            this.PtMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // TblUcMain
            // 
            this.TblUcMain.ColumnCount = 1;
            this.TblUcMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TblUcMain.Controls.Add(this.PtMain, 0, 0);
            this.TblUcMain.Controls.Add(this.TblButtons, 0, 1);
            this.TblUcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TblUcMain.Location = new System.Drawing.Point(0, 0);
            this.TblUcMain.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TblUcMain.Name = "TblUcMain";
            this.TblUcMain.RowCount = 2;
            this.TblUcMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TblUcMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TblUcMain.Size = new System.Drawing.Size(300, 365);
            this.TblUcMain.TabIndex = 0;
            // 
            // PtMain
            // 
            this.PtMain.Controls.Add(this.DgvMain);
            this.PtMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PtMain.Location = new System.Drawing.Point(5, 5);
            this.PtMain.Margin = new System.Windows.Forms.Padding(5);
            this.PtMain.Name = "PtMain";
            this.PtMain.Padding = new System.Windows.Forms.Padding(3);
            this.PtMain.Size = new System.Drawing.Size(290, 305);
            this.PtMain.TabIndex = 2;
            // 
            // DgvMain
            // 
            this.DgvMain.AllowUserToAddRows = false;
            this.DgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvMain.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvMain.BackgroundColor = System.Drawing.Color.White;
            this.DgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMain.ColumnHeadersVisible = false;
            this.DgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvMain.Location = new System.Drawing.Point(3, 3);
            this.DgvMain.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.DgvMain.Name = "DgvMain";
            this.DgvMain.RowHeadersVisible = false;
            this.DgvMain.Size = new System.Drawing.Size(284, 299);
            this.DgvMain.TabIndex = 1;
            // 
            // TblButtons
            // 
            this.TblButtons.ColumnCount = 2;
            this.TblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TblButtons.Location = new System.Drawing.Point(3, 318);
            this.TblButtons.Name = "TblButtons";
            this.TblButtons.RowCount = 1;
            this.TblButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblButtons.Size = new System.Drawing.Size(294, 44);
            this.TblButtons.TabIndex = 3;
            // 
            // BtNo
            // 
            this.BtNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtNo.Location = new System.Drawing.Point(3, 378);
            this.BtNo.Name = "BtNo";
            this.BtNo.Size = new System.Drawing.Size(500, 34);
            this.BtNo.TabIndex = 3;
            this.BtNo.Text = "No";
            this.BtNo.UseVisualStyleBackColor = true;
            // 
            // BtYes
            // 
            this.BtYes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtYes.Location = new System.Drawing.Point(3, 378);
            this.BtYes.Name = "BtYes";
            this.BtYes.Size = new System.Drawing.Size(500, 34);
            this.BtYes.TabIndex = 3;
            this.BtYes.Text = "Yes";
            this.BtYes.UseVisualStyleBackColor = true;
            // 
            // BtStart
            // 
            this.BtStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtStart.Location = new System.Drawing.Point(3, 378);
            this.BtStart.Name = "BtStart";
            this.BtStart.Size = new System.Drawing.Size(500, 34);
            this.BtStart.TabIndex = 3;
            this.BtStart.Text = "Start";
            this.BtStart.UseVisualStyleBackColor = true;
            // 
            // UcMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.TblUcMain);
            this.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "UcMain";
            this.Size = new System.Drawing.Size(300, 365);
            this.TblUcMain.ResumeLayout(false);
            this.PtMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvMain)).EndInit();
            this.ResumeLayout(false);

  }
  #endregion

  private Panel PtMain;
  internal DataGridView DgvMain;
  private TableLayoutPanel TblUcMain;

  private TableLayoutPanel TblButtons;
  internal Button BtNo, BtYes, BtStart;
}
