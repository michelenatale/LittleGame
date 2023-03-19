
namespace michele.natale.Games;

partial class FrmMain
{
  /// <summary>
  ///  Required designer variable.
  /// </summary>
  private System.ComponentModel.IContainer components = null;

  /// <summary>
  ///  Clean up any resources being used.
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
  ///  Required method for Designer support - do not modify
  ///  the contents of this method with the code editor.
  /// </summary>
  private void InitializeComponent()
  {
      this.SsMain = new System.Windows.Forms.StatusStrip();
      this.TsslText = new System.Windows.Forms.ToolStripStatusLabel();
      this.MsMain = new System.Windows.Forms.MenuStrip();
      this.BtClose = new System.Windows.Forms.Button();
      this.TlpMain = new System.Windows.Forms.TableLayoutPanel();
      this.UcMainRun = new FrmLittleGame.UcMain();
      this.SsMain.SuspendLayout();
      this.TlpMain.SuspendLayout();
      this.SuspendLayout();
      // 
      // SsMain
      // 
      this.SsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsslText});
      this.SsMain.Location = new System.Drawing.Point(0, 439);
      this.SsMain.Name = "SsMain";
      this.SsMain.Padding = new System.Windows.Forms.Padding(2, 0, 22, 0);
      this.SsMain.Size = new System.Drawing.Size(434, 22);
      this.SsMain.TabIndex = 1;
      this.SsMain.Text = "Status";
      // 
      // TsslText
      // 
      this.TsslText.BackColor = System.Drawing.Color.Transparent;
      this.TsslText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.TsslText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.TsslText.ForeColor = System.Drawing.Color.Green;
      this.TsslText.Name = "TsslText";
      this.TsslText.Size = new System.Drawing.Size(410, 17);
      this.TsslText.Spring = true;
      this.TsslText.Text = "      Welcome";
      // 
      // MsMain
      // 
      this.MsMain.Location = new System.Drawing.Point(0, 0);
      this.MsMain.Name = "MsMain";
      this.MsMain.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
      this.MsMain.Size = new System.Drawing.Size(434, 24);
      this.MsMain.TabIndex = 2;
      this.MsMain.Text = "MsMain";
      // 
      // BtClose
      // 
      this.BtClose.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.BtClose.Location = new System.Drawing.Point(11, 378);
      this.BtClose.Margin = new System.Windows.Forms.Padding(11, 3, 11, 3);
      this.BtClose.Name = "BtClose";
      this.BtClose.Size = new System.Drawing.Size(412, 34);
      this.BtClose.TabIndex = 3;
      this.BtClose.Text = "Close";
      this.BtClose.UseVisualStyleBackColor = true;
      this.BtClose.Click += new System.EventHandler(this.Buttons_Click);
      // 
      // TlpMain
      // 
      this.TlpMain.ColumnCount = 1;
      this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.TlpMain.Controls.Add(this.BtClose, 0, 1);
      this.TlpMain.Controls.Add(this.UcMainRun, 0, 0);
      this.TlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
      this.TlpMain.Location = new System.Drawing.Point(0, 24);
      this.TlpMain.Name = "TlpMain";
      this.TlpMain.RowCount = 2;
      this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
      this.TlpMain.Size = new System.Drawing.Size(434, 415);
      this.TlpMain.TabIndex = 4;
      // 
      // UcMainRun
      // 
      this.UcMainRun.BackColor = System.Drawing.Color.Transparent;
      this.UcMainRun.Dock = System.Windows.Forms.DockStyle.Fill;
      this.UcMainRun.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.UcMainRun.Location = new System.Drawing.Point(5, 4);
      this.UcMainRun.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
      this.UcMainRun.Name = "UcMainRun";
      this.UcMainRun.Size = new System.Drawing.Size(424, 367);
      this.UcMainRun.TabIndex = 4;
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(434, 461);
      this.Controls.Add(this.TlpMain);
      this.Controls.Add(this.SsMain);
      this.Controls.Add(this.MsMain);
      this.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.MainMenuStrip = this.MsMain;
      this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
      this.MaximumSize = new System.Drawing.Size(450, 500);
      this.MinimumSize = new System.Drawing.Size(330, 500);
      this.Name = "FrmMain";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "LittleGame - Created by © Michele Natale";
      this.SsMain.ResumeLayout(false);
      this.SsMain.PerformLayout();
      this.TlpMain.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

  }

  #endregion
  private StatusStrip SsMain;
  private MenuStrip MsMain;
  private Button BtClose;
  private TableLayoutPanel TlpMain;
  private FrmLittleGame.UcMain UcMainRun;
  private ToolStripStatusLabel TsslText;
}
