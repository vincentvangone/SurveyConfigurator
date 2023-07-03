namespace SurveryConfigurator
{
    partial class FormEdit
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
            this.panelUCEdit = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelUCEdit
            // 
            this.panelUCEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(157)))), ((int)(((byte)(155)))));
            this.panelUCEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUCEdit.Font = new System.Drawing.Font("Cascadia Code SemiLight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelUCEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(50)))), ((int)(((byte)(82)))));
            this.panelUCEdit.Location = new System.Drawing.Point(0, 0);
            this.panelUCEdit.Name = "panelUCEdit";
            this.panelUCEdit.Size = new System.Drawing.Size(800, 450);
            this.panelUCEdit.TabIndex = 0;
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelUCEdit);
            this.Name = "FormEdit";
            this.Text = "Edit";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUCEdit;
    }
}