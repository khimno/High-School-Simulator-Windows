namespace High_School_Simulator_Cs_Win64
{
    partial class Form1
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
            this.done_label = new System.Windows.Forms.Label();
            this.stress_label = new System.Windows.Forms.Label();
            this.missing_label = new System.Windows.Forms.Label();
            this.fatigue_label = new System.Windows.Forms.Label();
            this.grade_label = new System.Windows.Forms.Label();
            this.status_label = new System.Windows.Forms.Label();
            this.work_btn = new System.Windows.Forms.Button();
            this.cram_btn = new System.Windows.Forms.Button();
            this.info_btn = new System.Windows.Forms.Button();
            this.sleep_btn = new System.Windows.Forms.Button();
            this.cheat_btn = new System.Windows.Forms.Button();
            this.math_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // done_label
            // 
            this.done_label.AutoSize = true;
            this.done_label.Location = new System.Drawing.Point(165, 22);
            this.done_label.Name = "done_label";
            this.done_label.Size = new System.Drawing.Size(74, 13);
            this.done_label.TabIndex = 0;
            this.done_label.Text = "Work Done: 0";
            // 
            // stress_label
            // 
            this.stress_label.AutoSize = true;
            this.stress_label.Location = new System.Drawing.Point(165, 51);
            this.stress_label.Name = "stress_label";
            this.stress_label.Size = new System.Drawing.Size(48, 13);
            this.stress_label.TabIndex = 1;
            this.stress_label.Text = "Stress: 0";
            // 
            // missing_label
            // 
            this.missing_label.AutoSize = true;
            this.missing_label.Location = new System.Drawing.Point(165, 80);
            this.missing_label.Name = "missing_label";
            this.missing_label.Size = new System.Drawing.Size(116, 13);
            this.missing_label.TabIndex = 2;
            this.missing_label.Text = "Assignments Missing: 0";
            // 
            // fatigue_label
            // 
            this.fatigue_label.AutoSize = true;
            this.fatigue_label.Location = new System.Drawing.Point(165, 109);
            this.fatigue_label.Name = "fatigue_label";
            this.fatigue_label.Size = new System.Drawing.Size(54, 13);
            this.fatigue_label.TabIndex = 3;
            this.fatigue_label.Text = "Fatigue: 0";
            // 
            // grade_label
            // 
            this.grade_label.AutoSize = true;
            this.grade_label.Location = new System.Drawing.Point(165, 138);
            this.grade_label.Name = "grade_label";
            this.grade_label.Size = new System.Drawing.Size(68, 13);
            this.grade_label.TabIndex = 4;
            this.grade_label.Text = "Grade: 100%";
            // 
            // status_label
            // 
            this.status_label.AutoSize = true;
            this.status_label.Location = new System.Drawing.Point(165, 167);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(75, 13);
            this.status_label.TabIndex = 5;
            this.status_label.Text = "Do some work";
            // 
            // work_btn
            // 
            this.work_btn.Location = new System.Drawing.Point(5, 41);
            this.work_btn.Name = "work_btn";
            this.work_btn.Size = new System.Drawing.Size(75, 23);
            this.work_btn.TabIndex = 6;
            this.work_btn.Text = "Do Work";
            this.work_btn.UseVisualStyleBackColor = true;
            this.work_btn.Click += new System.EventHandler(this.work_btn_Click);
            // 
            // cram_btn
            // 
            this.cram_btn.Location = new System.Drawing.Point(5, 70);
            this.cram_btn.Name = "cram_btn";
            this.cram_btn.Size = new System.Drawing.Size(75, 23);
            this.cram_btn.TabIndex = 7;
            this.cram_btn.Text = "Cram Work";
            this.cram_btn.UseVisualStyleBackColor = true;
            // 
            // info_btn
            // 
            this.info_btn.Location = new System.Drawing.Point(5, 12);
            this.info_btn.Name = "info_btn";
            this.info_btn.Size = new System.Drawing.Size(75, 23);
            this.info_btn.TabIndex = 8;
            this.info_btn.Text = "Information";
            this.info_btn.UseVisualStyleBackColor = true;
            this.info_btn.Click += new System.EventHandler(this.info_btn_Click);
            // 
            // sleep_btn
            // 
            this.sleep_btn.Location = new System.Drawing.Point(5, 128);
            this.sleep_btn.Name = "sleep_btn";
            this.sleep_btn.Size = new System.Drawing.Size(75, 23);
            this.sleep_btn.TabIndex = 9;
            this.sleep_btn.Text = "Sleep";
            this.sleep_btn.UseVisualStyleBackColor = true;
            // 
            // cheat_btn
            // 
            this.cheat_btn.Location = new System.Drawing.Point(5, 99);
            this.cheat_btn.Name = "cheat_btn";
            this.cheat_btn.Size = new System.Drawing.Size(75, 23);
            this.cheat_btn.TabIndex = 10;
            this.cheat_btn.Text = "Cheat";
            this.cheat_btn.UseVisualStyleBackColor = true;
            // 
            // math_btn
            // 
            this.math_btn.Location = new System.Drawing.Point(5, 157);
            this.math_btn.Name = "math_btn";
            this.math_btn.Size = new System.Drawing.Size(112, 23);
            this.math_btn.TabIndex = 11;
            this.math_btn.Text = "do useless math";
            this.math_btn.UseVisualStyleBackColor = true;
            this.math_btn.Click += new System.EventHandler(this.math_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 197);
            this.Controls.Add(this.math_btn);
            this.Controls.Add(this.cheat_btn);
            this.Controls.Add(this.sleep_btn);
            this.Controls.Add(this.info_btn);
            this.Controls.Add(this.cram_btn);
            this.Controls.Add(this.work_btn);
            this.Controls.Add(this.status_label);
            this.Controls.Add(this.grade_label);
            this.Controls.Add(this.fatigue_label);
            this.Controls.Add(this.missing_label);
            this.Controls.Add(this.stress_label);
            this.Controls.Add(this.done_label);
            this.Name = "Form1";
            this.Text = "High School Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label done_label;
        private System.Windows.Forms.Label stress_label;
        private System.Windows.Forms.Label missing_label;
        private System.Windows.Forms.Label fatigue_label;
        private System.Windows.Forms.Label grade_label;
        private System.Windows.Forms.Label status_label;
        private System.Windows.Forms.Button work_btn;
        private System.Windows.Forms.Button cram_btn;
        private System.Windows.Forms.Button info_btn;
        private System.Windows.Forms.Button sleep_btn;
        private System.Windows.Forms.Button cheat_btn;
        private System.Windows.Forms.Button math_btn;
    }
}

