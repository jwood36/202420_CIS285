using System.Windows.Forms;

namespace EduCal
{
    partial class frmAbout : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.StatusStrip statusMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem mnuEditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.TextBox textBoxDescription;


        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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

            // This should be present in your form's designer code
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.mnuEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            /*this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Location = new System.Drawing.Point(0, 49);
            this.menuStrip1.Name = "mnuMain";
            this.menuStrip1.Size = new System.Drawing.Size(2874, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "";*/
            // 
            // menuStrip2
            // 
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEditToolStripMenuItem,
            this.editToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "mnuMain";
            this.menuStrip2.Size = new System.Drawing.Size(2874, 49);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "";
            // 
            // mnuEditToolStripMenuItem
            // 
            this.mnuEditToolStripMenuItem.Name = "mnuFile";
            this.mnuEditToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.mnuEditToolStripMenuItem.Text = "&File";
            this.mnuEditToolStripMenuItem.Click += new System.EventHandler(this.mnuEditToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "mnuEdit";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "mnuAbout";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.aboutToolStripMenuItem.Text = "Abou&t";
            // 
            // mnuMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //this.ClientSize = new System.Drawing.Size(2874, 1058);
            //this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "mnuMain";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
            // Example:
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Top;
            //this.menuStrip1.Padding = new Padding(5);  // Set your desired padding value

            this.menuStrip2.Padding = new Padding(0);  // Set your desired padding value



            // 
            // stat
            // usMain
            // 
            this.statusMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusMain.SuspendLayout();
            this.statusMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.toolStripStatusLabel
            });
            this.statusMain.Location = new System.Drawing.Point(0, 0);
            this.statusMain.Name = "statusMain";
            this.statusMain.Size = new System.Drawing.Size(800, 22);
            this.statusMain.SizingGrip = false;
            this.statusMain.TabIndex = 0;
            this.statusMain.Text = "";
            this.statusMain.Dock = DockStyle.Bottom;

            // 
            // toolStripStatusLabel
            // 
            /* this.toolStripStatusLabel.Name = "statusMain";
             this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
             this.toolStripStatusLabel.Spring = true;
             this.toolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;*/
            // 
            // StatusBar
            // 
            this.Controls.Add(this.statusMain);
            this.statusMain.SuspendLayout();
            this.statusMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
    this.toolStripStatusLabel
});
            this.statusMain.Location = new System.Drawing.Point(0, 0);
            this.statusMain.Name = "statusMain";
            this.statusMain.Size = new System.Drawing.Size(800, 22);
            this.statusMain.SizingGrip = false;
            this.statusMain.TabIndex = 0;
            this.statusMain.Text = "";
            this.statusMain.Dock = DockStyle.Bottom;
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.tableLayoutPanel.Controls.Add(this.labelProductName, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.labelVersion, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.textBoxDescription, 1, 4);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(14, 14);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 6;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.80368F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.828221F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(624, 407);
            this.tableLayoutPanel.TabIndex = 0;
            this.tableLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel_Paint);
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;  
            this.labelProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProductName.Location = new System.Drawing.Point(214, 0);
            this.labelProductName.Margin = new System.Windows.Forms.Padding(9, 0, 4, 0);
            this.labelProductName.MaximumSize = new System.Drawing.Size(0, 50);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(406, 26);
            this.labelProductName.TabIndex = 19;
            this.labelProductName.Text = "Education Calendar\r\n";
            this.labelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelVersion.Location = new System.Drawing.Point(214, 56);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(9, 0, 4, 0);
            this.labelVersion.MaximumSize = new System.Drawing.Size(0, 50);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(406, 23);
            this.labelVersion.TabIndex = 0;
            this.labelVersion.Text = "2024.04";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDescription.Location = new System.Drawing.Point(214, 164);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(9, 5, 4, 5);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDescription.Size = new System.Drawing.Size(406, 194);
            this.textBoxDescription.TabIndex = 23;
            this.textBoxDescription.TabStop = false;
            this.textBoxDescription.Text = "Carstarphen, Shamar\r\nChaney, Tyas\r\nHaines, Colema\r\nJeane, Andrew\r\nKnight, Tony\r\nSawyer, Josh";
            this.textBoxDescription.TextChanged += new System.EventHandler(this.textBoxDescription_TextChanged);
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 600);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            this.Padding = new System.Windows.Forms.Padding(14);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About...";
            this.Load += new System.EventHandler(this.frmAbout_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
         


        }

        #endregion


    }
}
