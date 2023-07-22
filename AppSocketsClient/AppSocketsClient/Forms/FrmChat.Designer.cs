namespace AppSocketsClient.Forms
{
    partial class FrmChat
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
            this.pnlContacts = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlBase = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContacts
            // 
            this.pnlContacts.AutoScroll = true;
            this.pnlContacts.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlContacts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.pnlContacts.Location = new System.Drawing.Point(-5, 60);
            this.pnlContacts.Name = "pnlContacts";
            this.pnlContacts.Size = new System.Drawing.Size(326, 604);
            this.pnlContacts.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.panel1.Location = new System.Drawing.Point(-5, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1058, 60);
            this.panel1.TabIndex = 3;
            // 
            // pnlBase
            // 
            this.pnlBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(37)))));
            this.pnlBase.Controls.Add(this.label1);
            this.pnlBase.Location = new System.Drawing.Point(319, 60);
            this.pnlBase.Name = "pnlBase";
            this.pnlBase.Size = new System.Drawing.Size(734, 604);
            this.pnlBase.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FloralWhite;
            this.label1.Location = new System.Drawing.Point(248, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione un chat";
            // 
            // FrmChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1052, 662);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlContacts);
            this.Controls.Add(this.pnlBase);
            this.MaximumSize = new System.Drawing.Size(1070, 709);
            this.Name = "FrmChat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmChat";
            this.pnlBase.ResumeLayout(false);
            this.pnlBase.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlContacts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlBase;
        private System.Windows.Forms.Label label1;
    }
}