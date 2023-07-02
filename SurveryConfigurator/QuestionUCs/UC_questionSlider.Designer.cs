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
            this.labelSliderStartValue = new System.Windows.Forms.Label();
            this.labelSliderEndValue = new System.Windows.Forms.Label();
            this.labelSliderEndCaption = new System.Windows.Forms.Label();
            this.labelSliderStartCaption = new System.Windows.Forms.Label();
            this.numericStValue = new System.Windows.Forms.NumericUpDown();
            this.numericEndValue = new System.Windows.Forms.NumericUpDown();
            this.textBoxStCaption = new System.Windows.Forms.TextBox();
            this.textBoxEndCaption = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericStValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEndValue)).BeginInit();
            this.SuspendLayout();
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
            this.numericStValue.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericStValue.Name = "numericStValue";
            this.numericStValue.Size = new System.Drawing.Size(151, 31);
            this.numericStValue.TabIndex = 5;
            this.numericStValue.ValueChanged += new System.EventHandler(this.numericStValue_ValueChanged);
            // 
            // numericEndValue
            // 
            this.numericEndValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericEndValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(157)))), ((int)(((byte)(155)))));
            this.numericEndValue.ForeColor = System.Drawing.Color.White;
            this.numericEndValue.Location = new System.Drawing.Point(959, 315);
            this.numericEndValue.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericEndValue.Name = "numericEndValue";
            this.numericEndValue.Size = new System.Drawing.Size(151, 31);
            this.numericEndValue.TabIndex = 6;
            this.numericEndValue.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericEndValue.ValueChanged += new System.EventHandler(this.numericEndValue_ValueChanged);
            // 
            // textBoxStCaption
            // 
            this.textBoxStCaption.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxStCaption.Location = new System.Drawing.Point(481, 385);
            this.textBoxStCaption.Name = "textBoxStCaption";
            this.textBoxStCaption.Size = new System.Drawing.Size(172, 31);
            this.textBoxStCaption.TabIndex = 7;
            this.textBoxStCaption.TextChanged += new System.EventHandler(this.textBoxStCaption_TextChanged);
            // 
            // textBoxEndCaption
            // 
            this.textBoxEndCaption.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxEndCaption.Location = new System.Drawing.Point(979, 388);
            this.textBoxEndCaption.Name = "textBoxEndCaption";
            this.textBoxEndCaption.Size = new System.Drawing.Size(171, 31);
            this.textBoxEndCaption.TabIndex = 8;
            this.textBoxEndCaption.TextChanged += new System.EventHandler(this.textBoxEndCaption_TextChanged);
            // 
            // UC_questionSlider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxEndCaption);
            this.Controls.Add(this.textBoxStCaption);
            this.Controls.Add(this.numericEndValue);
            this.Controls.Add(this.numericStValue);
            this.Controls.Add(this.labelSliderStartCaption);
            this.Controls.Add(this.labelSliderEndCaption);
            this.Controls.Add(this.labelSliderEndValue);
            this.Controls.Add(this.labelSliderStartValue);
            this.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(31)))), ((int)(((byte)(64)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UC_questionSlider";
            this.Size = new System.Drawing.Size(1389, 824);
            ((System.ComponentModel.ISupportInitialize)(this.numericStValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEndValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelSliderStartValue;
        private System.Windows.Forms.Label labelSliderEndValue;
        private System.Windows.Forms.Label labelSliderEndCaption;
        private System.Windows.Forms.Label labelSliderStartCaption;
        private System.Windows.Forms.NumericUpDown numericStValue;
        private System.Windows.Forms.NumericUpDown numericEndValue;
        private System.Windows.Forms.TextBox textBoxStCaption;
        private System.Windows.Forms.TextBox textBoxEndCaption;
    }
}
