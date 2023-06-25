using System.Windows.Forms;

namespace SurveyConfigurator.Tabs
{
    partial class UC_Create
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
            this.panelAddQuestionButton = new System.Windows.Forms.Panel();
            this.buttonAddQues = new System.Windows.Forms.Button();
            this.panelQuestionType = new System.Windows.Forms.Panel();
            this.comboBoxQuesTypes = new System.Windows.Forms.ComboBox();
            this.labelQuestionType = new System.Windows.Forms.Label();
            this.panelAddQuestion = new System.Windows.Forms.Panel();
            this.labelQuestionText = new System.Windows.Forms.Label();
            this.textBoxQuesText = new System.Windows.Forms.TextBox();
            this.panelCommonInput = new System.Windows.Forms.Panel();
            this.panelAddQuestionButton.SuspendLayout();
            this.panelQuestionType.SuspendLayout();
            this.panelCommonInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAddQuestionButton
            // 
            this.panelAddQuestionButton.Controls.Add(this.buttonAddQues);
            this.panelAddQuestionButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAddQuestionButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(31)))), ((int)(((byte)(64)))));
            this.panelAddQuestionButton.Location = new System.Drawing.Point(0, 696);
            this.panelAddQuestionButton.Name = "panelAddQuestionButton";
            this.panelAddQuestionButton.Size = new System.Drawing.Size(1240, 119);
            this.panelAddQuestionButton.TabIndex = 3;
            // 
            // buttonAddQues
            // 
            this.buttonAddQues.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddQues.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(157)))), ((int)(((byte)(155)))));
            this.buttonAddQues.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(104)))), ((int)(((byte)(123)))));
            this.buttonAddQues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddQues.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddQues.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(31)))), ((int)(((byte)(64)))));
            this.buttonAddQues.Location = new System.Drawing.Point(479, 6);
            this.buttonAddQues.Name = "buttonAddQues";
            this.buttonAddQues.Size = new System.Drawing.Size(312, 58);
            this.buttonAddQues.TabIndex = 1;
            this.buttonAddQues.Text = "Add Question";
            this.buttonAddQues.UseVisualStyleBackColor = false;
            this.buttonAddQues.Click += new System.EventHandler(this.buttonAddQues_Click);
            // 
            // panelQuestionType
            // 
            this.panelQuestionType.Controls.Add(this.comboBoxQuesTypes);
            this.panelQuestionType.Controls.Add(this.labelQuestionType);
            this.panelQuestionType.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelQuestionType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(31)))), ((int)(((byte)(64)))));
            this.panelQuestionType.Location = new System.Drawing.Point(0, 0);
            this.panelQuestionType.Name = "panelQuestionType";
            this.panelQuestionType.Size = new System.Drawing.Size(1240, 69);
            this.panelQuestionType.TabIndex = 4;
            // 
            // comboBoxQuesTypes
            // 
            this.comboBoxQuesTypes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxQuesTypes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(50)))), ((int)(((byte)(82)))));
            this.comboBoxQuesTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxQuesTypes.ForeColor = System.Drawing.Color.GhostWhite;
            this.comboBoxQuesTypes.FormattingEnabled = true;
            this.comboBoxQuesTypes.Items.AddRange(new object[] {
            "Smiley Faces",
            "Stars",
            "Slider"});
            this.comboBoxQuesTypes.Location = new System.Drawing.Point(505, 20);
            this.comboBoxQuesTypes.MaxDropDownItems = 3;
            this.comboBoxQuesTypes.Name = "comboBoxQuesTypes";
            this.comboBoxQuesTypes.Size = new System.Drawing.Size(320, 35);
            this.comboBoxQuesTypes.TabIndex = 1;
            this.comboBoxQuesTypes.SelectedIndexChanged += new System.EventHandler(this.comboBoxQuesTypes_SelectedIndexChanged);
            // 
            // labelQuestionType
            // 
            this.labelQuestionType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelQuestionType.AutoSize = true;
            this.labelQuestionType.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestionType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(31)))), ((int)(((byte)(64)))));
            this.labelQuestionType.Location = new System.Drawing.Point(303, 20);
            this.labelQuestionType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuestionType.Name = "labelQuestionType";
            this.labelQuestionType.Size = new System.Drawing.Size(180, 27);
            this.labelQuestionType.TabIndex = 2;
            this.labelQuestionType.Text = "Question Type:";
            // 
            // panelAddQuestion
            // 
            this.panelAddQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAddQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(31)))), ((int)(((byte)(64)))));
            this.panelAddQuestion.Location = new System.Drawing.Point(0, 202);
            this.panelAddQuestion.Name = "panelAddQuestion";
            this.panelAddQuestion.Size = new System.Drawing.Size(1240, 494);
            this.panelAddQuestion.TabIndex = 5;
            // 
            // labelQuestionText
            // 
            this.labelQuestionText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelQuestionText.AutoSize = true;
            this.labelQuestionText.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestionText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(31)))), ((int)(((byte)(64)))));
            this.labelQuestionText.Location = new System.Drawing.Point(528, 25);
            this.labelQuestionText.Name = "labelQuestionText";
            this.labelQuestionText.Size = new System.Drawing.Size(252, 27);
            this.labelQuestionText.TabIndex = 0;
            this.labelQuestionText.Text = "Enter Question Text:";
            // 
            // textBoxQuesText
            // 
            this.textBoxQuesText.AcceptsReturn = true;
            this.textBoxQuesText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxQuesText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(157)))), ((int)(((byte)(155)))));
            this.textBoxQuesText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxQuesText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(104)))), ((int)(((byte)(123)))));
            this.textBoxQuesText.Location = new System.Drawing.Point(273, 55);
            this.textBoxQuesText.Multiline = true;
            this.textBoxQuesText.Name = "textBoxQuesText";
            this.textBoxQuesText.Size = new System.Drawing.Size(736, 72);
            this.textBoxQuesText.TabIndex = 1;
            // 
            // panelCommonInput
            // 
            this.panelCommonInput.Controls.Add(this.labelQuestionText);
            this.panelCommonInput.Controls.Add(this.textBoxQuesText);
            this.panelCommonInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCommonInput.Location = new System.Drawing.Point(0, 69);
            this.panelCommonInput.Name = "panelCommonInput";
            this.panelCommonInput.Size = new System.Drawing.Size(1240, 133);
            this.panelCommonInput.TabIndex = 6;
            // 
            // UC_Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelAddQuestion);
            this.Controls.Add(this.panelCommonInput);
            this.Controls.Add(this.panelQuestionType);
            this.Controls.Add(this.panelAddQuestionButton);
            this.Font = new System.Drawing.Font("Cascadia Code Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UC_Create";
            this.Size = new System.Drawing.Size(1240, 815);
            this.panelAddQuestionButton.ResumeLayout(false);
            this.panelQuestionType.ResumeLayout(false);
            this.panelQuestionType.PerformLayout();
            this.panelCommonInput.ResumeLayout(false);
            this.panelCommonInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelAddQuestionButton;
        private System.Windows.Forms.Button buttonAddQues;
        private System.Windows.Forms.Panel panelQuestionType;
        private System.Windows.Forms.Panel panelAddQuestion;
        private ComboBox comboBoxQuesTypes;
        private Label labelQuestionType;
        private TextBox textBoxQuesText;
        private Label labelQuestionText;
        private Panel panelCommonInput;
    }
}
