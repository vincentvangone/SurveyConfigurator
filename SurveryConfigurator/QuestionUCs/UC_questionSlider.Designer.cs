namespace SurveyConfigurator.QuestionUCs
{
    partial class UC_questionSlider
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.labelSliderStartValue = new System.Windows.Forms.Label();
            this.labelSliderEndValue = new System.Windows.Forms.Label();
            this.labelSliderEndCaption = new System.Windows.Forms.Label();
            this.labelSliderStartCaption = new System.Windows.Forms.Label();
            this.numericStValue = new System.Windows.Forms.NumericUpDown();
            this.numericEndValue = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEndValue)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.trackBar1.Location = new System.Drawing.Point(327, 499);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(773, 70);
            this.trackBar1.TabIndex = 0;
            // 
            // labelSliderStartValue
            // 
            this.labelSliderStartValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSliderStartValue.AutoSize = true;
            this.labelSliderStartValue.Location = new System.Drawing.Point(216, 315);
            this.labelSliderStartValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSliderStartValue.Name = "labelSliderStartValue";
            this.labelSliderStartValue.Size = new System.Drawing.Size(240, 27);
            this.labelSliderStartValue.TabIndex = 1;
            this.labelSliderStartValue.Text = "Slider Start Value:";
            // 
            // labelSliderEndValue
            // 
            this.labelSliderEndValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSliderEndValue.AutoSize = true;
            this.labelSliderEndValue.Location = new System.Drawing.Point(716, 315);
            this.labelSliderEndValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSliderEndValue.Name = "labelSliderEndValue";
            this.labelSliderEndValue.Size = new System.Drawing.Size(216, 27);
            this.labelSliderEndValue.TabIndex = 2;
            this.labelSliderEndValue.Text = "Slider End Value:";
            this.labelSliderEndValue.Click += new System.EventHandler(this.labelSliderEndValue_Click);
            // 
            // labelSliderEndCaption
            // 
            this.labelSliderEndCaption.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSliderEndCaption.AutoSize = true;
            this.labelSliderEndCaption.Location = new System.Drawing.Point(716, 388);
            this.labelSliderEndCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSliderEndCaption.Name = "labelSliderEndCaption";
            this.labelSliderEndCaption.Size = new System.Drawing.Size(240, 27);
            this.labelSliderEndCaption.TabIndex = 3;
            this.labelSliderEndCaption.Text = "Slider End Caption:";
            // 
            // labelSliderStartCaption
            // 
            this.labelSliderStartCaption.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSliderStartCaption.AutoSize = true;
            this.labelSliderStartCaption.Location = new System.Drawing.Point(216, 388);
            this.labelSliderStartCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSliderStartCaption.Name = "labelSliderStartCaption";
            this.labelSliderStartCaption.Size = new System.Drawing.Size(264, 27);
            this.labelSliderStartCaption.TabIndex = 4;
            this.labelSliderStartCaption.Text = "Slider Start Caption:";
            // 
            // numericStValue
            // 
            this.numericStValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericStValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(157)))), ((int)(((byte)(155)))));
            this.numericStValue.ForeColor = System.Drawing.Color.White;
            this.numericStValue.Location = new System.Drawing.Point(463, 315);
            this.numericStValue.Name = "numericStValue";
            this.numericStValue.Size = new System.Drawing.Size(151, 31);
            this.numericStValue.TabIndex = 5;
            // 
            // numericEndValue
            // 
            this.numericEndValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericEndValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(157)))), ((int)(((byte)(155)))));
            this.numericEndValue.ForeColor = System.Drawing.Color.White;
            this.numericEndValue.Location = new System.Drawing.Point(959, 315);
            this.numericEndValue.Name = "numericEndValue";
            this.numericEndValue.Size = new System.Drawing.Size(151, 31);
            this.numericEndValue.TabIndex = 6;
            // 
            // UC_questionSlider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numericEndValue);
            this.Controls.Add(this.numericStValue);
            this.Controls.Add(this.labelSliderStartCaption);
            this.Controls.Add(this.labelSliderEndCaption);
            this.Controls.Add(this.labelSliderEndValue);
            this.Controls.Add(this.labelSliderStartValue);
            this.Controls.Add(this.trackBar1);
            this.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(31)))), ((int)(((byte)(64)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UC_questionSlider";
            this.Size = new System.Drawing.Size(1389, 824);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEndValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label labelSliderStartValue;
        private System.Windows.Forms.Label labelSliderEndValue;
        private System.Windows.Forms.Label labelSliderEndCaption;
        private System.Windows.Forms.Label labelSliderStartCaption;
        private System.Windows.Forms.NumericUpDown numericStValue;
        private System.Windows.Forms.NumericUpDown numericEndValue;
    }
}
