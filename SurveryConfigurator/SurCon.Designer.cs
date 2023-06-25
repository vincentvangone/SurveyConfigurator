using System.Drawing;
using static System.Net.Mime.MediaTypeNames;

namespace SurveyConfigurator
{
    partial class HomePage
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
            System.Windows.Forms.PictureBox picLogo;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.panelNavBar = new System.Windows.Forms.Panel();
            this.buttonNavCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonNavView = new System.Windows.Forms.Button();
            this.buttonNavEdit = new System.Windows.Forms.Button();
            this.buttonNavHelp = new System.Windows.Forms.Button();
            this.panelMainContainer = new System.Windows.Forms.Panel();
            picLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(picLogo)).BeginInit();
            this.panelNavBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            picLogo.Dock = System.Windows.Forms.DockStyle.Left;
            picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            picLogo.Location = new System.Drawing.Point(0, 0);
            picLogo.Margin = new System.Windows.Forms.Padding(10, 30, 10, 10);
            picLogo.Name = "picLogo";
            picLogo.Padding = new System.Windows.Forms.Padding(40, 10, 200, 10);
            picLogo.Size = new System.Drawing.Size(362, 139);
            picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            picLogo.Click += new System.EventHandler(this.picLogo_Click);
            // 
            // panelNavBar
            // 
            this.panelNavBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(68)))), ((int)(((byte)(98)))));
            this.panelNavBar.Controls.Add(this.buttonNavCreate);
            this.panelNavBar.Controls.Add(this.label1);
            this.panelNavBar.Controls.Add(this.buttonNavView);
            this.panelNavBar.Controls.Add(this.buttonNavEdit);
            this.panelNavBar.Controls.Add(picLogo);
            this.panelNavBar.Controls.Add(this.buttonNavHelp);
            this.panelNavBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNavBar.Location = new System.Drawing.Point(0, 0);
            this.panelNavBar.Name = "panelNavBar";
            this.panelNavBar.Size = new System.Drawing.Size(1444, 139);
            this.panelNavBar.TabIndex = 0;
            // 
            // buttonNavCreate
            // 
            this.buttonNavCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonNavCreate.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonNavCreate.FlatAppearance.BorderSize = 0;
            this.buttonNavCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNavCreate.Font = new System.Drawing.Font("Cascadia Code Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNavCreate.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonNavCreate.Image = ((System.Drawing.Image)(resources.GetObject("buttonNavCreate.Image")));
            this.buttonNavCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNavCreate.Location = new System.Drawing.Point(578, 0);
            this.buttonNavCreate.Margin = new System.Windows.Forms.Padding(0);
            this.buttonNavCreate.Name = "buttonNavCreate";
            this.buttonNavCreate.Padding = new System.Windows.Forms.Padding(40, 10, 10, 10);
            this.buttonNavCreate.Size = new System.Drawing.Size(228, 139);
            this.buttonNavCreate.TabIndex = 2;
            this.buttonNavCreate.Text = "Create";
            this.buttonNavCreate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNavCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonNavCreate.UseVisualStyleBackColor = true;
            this.buttonNavCreate.Click += new System.EventHandler(this.buttonNavCreate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(157)))), ((int)(((byte)(155)))));
            this.label1.Location = new System.Drawing.Point(171, 25);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label1.Size = new System.Drawing.Size(169, 70);
            this.label1.TabIndex = 6;
            this.label1.Text = "Survey \r\nConfigurator";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonNavView
            // 
            this.buttonNavView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonNavView.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonNavView.FlatAppearance.BorderSize = 0;
            this.buttonNavView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNavView.Font = new System.Drawing.Font("Cascadia Code Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNavView.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonNavView.Image = ((System.Drawing.Image)(resources.GetObject("buttonNavView.Image")));
            this.buttonNavView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNavView.Location = new System.Drawing.Point(806, 0);
            this.buttonNavView.Name = "buttonNavView";
            this.buttonNavView.Padding = new System.Windows.Forms.Padding(20, 10, 10, 10);
            this.buttonNavView.Size = new System.Drawing.Size(192, 139);
            this.buttonNavView.TabIndex = 4;
            this.buttonNavView.Text = "View";
            this.buttonNavView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNavView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonNavView.UseVisualStyleBackColor = true;
            this.buttonNavView.Click += new System.EventHandler(this.buttonNavView_Click);
            // 
            // buttonNavEdit
            // 
            this.buttonNavEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonNavEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonNavEdit.FlatAppearance.BorderSize = 0;
            this.buttonNavEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNavEdit.Font = new System.Drawing.Font("Cascadia Code Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNavEdit.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonNavEdit.Image = ((System.Drawing.Image)(resources.GetObject("buttonNavEdit.Image")));
            this.buttonNavEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNavEdit.Location = new System.Drawing.Point(998, 0);
            this.buttonNavEdit.Name = "buttonNavEdit";
            this.buttonNavEdit.Padding = new System.Windows.Forms.Padding(20, 10, 10, 10);
            this.buttonNavEdit.Size = new System.Drawing.Size(191, 139);
            this.buttonNavEdit.TabIndex = 3;
            this.buttonNavEdit.Text = "Edit";
            this.buttonNavEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNavEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonNavEdit.UseVisualStyleBackColor = true;
            this.buttonNavEdit.Click += new System.EventHandler(this.buttonNavEdit_Click);
            // 
            // buttonNavHelp
            // 
            this.buttonNavHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonNavHelp.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonNavHelp.FlatAppearance.BorderSize = 0;
            this.buttonNavHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNavHelp.Font = new System.Drawing.Font("Cascadia Code Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNavHelp.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonNavHelp.Image = ((System.Drawing.Image)(resources.GetObject("buttonNavHelp.Image")));
            this.buttonNavHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNavHelp.Location = new System.Drawing.Point(1189, 0);
            this.buttonNavHelp.Name = "buttonNavHelp";
            this.buttonNavHelp.Padding = new System.Windows.Forms.Padding(20, 10, 10, 10);
            this.buttonNavHelp.Size = new System.Drawing.Size(255, 139);
            this.buttonNavHelp.TabIndex = 5;
            this.buttonNavHelp.Text = "Help";
            this.buttonNavHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNavHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonNavHelp.UseVisualStyleBackColor = true;
            this.buttonNavHelp.Click += new System.EventHandler(this.buttonNavHelp_Click);
            // 
            // panelMainContainer
            // 
            this.panelMainContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(104)))), ((int)(((byte)(123)))));
            this.panelMainContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainContainer.Location = new System.Drawing.Point(0, 139);
            this.panelMainContainer.MinimumSize = new System.Drawing.Size(1100, 700);
            this.panelMainContainer.Name = "panelMainContainer";
            this.panelMainContainer.Size = new System.Drawing.Size(1444, 842);
            this.panelMainContainer.TabIndex = 1;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(104)))), ((int)(((byte)(123)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1444, 981);
            this.Controls.Add(this.panelMainContainer);
            this.Controls.Add(this.panelNavBar);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1320, 1028);
            this.Name = "HomePage";
            this.Text = "Survey Configurator";
            ((System.ComponentModel.ISupportInitialize)(picLogo)).EndInit();
            this.panelNavBar.ResumeLayout(false);
            this.panelNavBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNavBar;
        private System.Windows.Forms.Button buttonNavEdit;
        private System.Windows.Forms.Button buttonNavCreate;
        private System.Windows.Forms.Button buttonNavHelp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMainContainer;
        private System.Windows.Forms.Button buttonNavView;
    }
}

