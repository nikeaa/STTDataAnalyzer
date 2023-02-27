using System.Windows.Forms;

namespace Windows_UI
{
    partial class Form1 : Form
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
            this.ddlPrimarySkill = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ddlSecondarySkill = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ddlSlotSkill = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ddlSlotTrait = new System.Windows.Forms.ComboBox();
            this.lbResults = new System.Windows.Forms.ListBox();
            this.btnFindCrew = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ddlPrimarySkill
            // 
            this.ddlPrimarySkill.FormattingEnabled = true;
            this.ddlPrimarySkill.Location = new System.Drawing.Point(42, 47);
            this.ddlPrimarySkill.Name = "ddlPrimarySkill";
            this.ddlPrimarySkill.Size = new System.Drawing.Size(121, 21);
            this.ddlPrimarySkill.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Primary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Secondary";
            // 
            // ddlSecondarySkill
            // 
            this.ddlSecondarySkill.FormattingEnabled = true;
            this.ddlSecondarySkill.Location = new System.Drawing.Point(43, 116);
            this.ddlSecondarySkill.Name = "ddlSecondarySkill";
            this.ddlSecondarySkill.Size = new System.Drawing.Size(121, 21);
            this.ddlSecondarySkill.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Slot Skill";
            // 
            // ddlSlotSkill
            // 
            this.ddlSlotSkill.FormattingEnabled = true;
            this.ddlSlotSkill.Location = new System.Drawing.Point(233, 47);
            this.ddlSlotSkill.Name = "ddlSlotSkill";
            this.ddlSlotSkill.Size = new System.Drawing.Size(121, 21);
            this.ddlSlotSkill.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Slot Trait";
            // 
            // ddlSlotTrait
            // 
            this.ddlSlotTrait.FormattingEnabled = true;
            this.ddlSlotTrait.Location = new System.Drawing.Point(233, 116);
            this.ddlSlotTrait.Name = "ddlSlotTrait";
            this.ddlSlotTrait.Size = new System.Drawing.Size(121, 21);
            this.ddlSlotTrait.TabIndex = 6;
            // 
            // lbResults
            // 
            this.lbResults.FormattingEnabled = true;
            this.lbResults.Location = new System.Drawing.Point(43, 171);
            this.lbResults.Name = "lbResults";
            this.lbResults.Size = new System.Drawing.Size(722, 264);
            this.lbResults.TabIndex = 8;
            // 
            // btnFindCrew
            // 
            this.btnFindCrew.Location = new System.Drawing.Point(412, 47);
            this.btnFindCrew.Name = "btnFindCrew";
            this.btnFindCrew.Size = new System.Drawing.Size(75, 23);
            this.btnFindCrew.TabIndex = 9;
            this.btnFindCrew.Text = "Find Crew";
            this.btnFindCrew.UseVisualStyleBackColor = true;
            this.btnFindCrew.Click += new System.EventHandler(this.btnFindCrew_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFindCrew);
            this.Controls.Add(this.lbResults);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ddlSlotTrait);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ddlSlotSkill);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ddlSecondarySkill);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ddlPrimarySkill);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ddlPrimarySkill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ddlSecondarySkill;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ddlSlotSkill;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ddlSlotTrait;
        private System.Windows.Forms.ListBox lbResults;
        private System.Windows.Forms.Button btnFindCrew;
    }
}

