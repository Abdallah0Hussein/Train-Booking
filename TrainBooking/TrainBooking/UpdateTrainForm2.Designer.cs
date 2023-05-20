﻿namespace TrainBooking
{
    partial class UpdateTrainForm2
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
            this.Title = new System.Windows.Forms.Label();
            this.UpdateTrain = new System.Windows.Forms.Button();
            this.TrainCapacity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TrainStatus = new System.Windows.Forms.TextBox();
            this.TrainName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Tai Le", 22F, System.Drawing.FontStyle.Bold);
            this.Title.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Title.Location = new System.Drawing.Point(22, 33);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(277, 48);
            this.Title.TabIndex = 18;
            this.Title.Text = "Update Train " + UpdateTrainForm1.trainID.ToString();
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            // 
            // UpdateTrain
            // 
            this.UpdateTrain.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold);
            this.UpdateTrain.ForeColor = System.Drawing.SystemColors.Highlight;
            this.UpdateTrain.Location = new System.Drawing.Point(188, 350);
            this.UpdateTrain.Name = "UpdateTrain";
            this.UpdateTrain.Size = new System.Drawing.Size(187, 49);
            this.UpdateTrain.TabIndex = 25;
            this.UpdateTrain.Text = "UPDATE";
            this.UpdateTrain.UseVisualStyleBackColor = true;
            this.UpdateTrain.Click += new System.EventHandler(this.UpdateTrain_Click);
            // 
            // TrainCapacity
            // 
            this.TrainCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.TrainCapacity.Location = new System.Drawing.Point(173, 255);
            this.TrainCapacity.Name = "TrainCapacity";
            this.TrainCapacity.Size = new System.Drawing.Size(316, 34);
            this.TrainCapacity.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(51, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 29);
            this.label5.TabIndex = 23;
            this.label5.Text = "Capacity";
            // 
            // TrainStatus
            // 
            this.TrainStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.TrainStatus.Location = new System.Drawing.Point(173, 190);
            this.TrainStatus.Name = "TrainStatus";
            this.TrainStatus.PasswordChar = '*';
            this.TrainStatus.Size = new System.Drawing.Size(316, 34);
            this.TrainStatus.TabIndex = 22;
            // 
            // TrainName
            // 
            this.TrainName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.TrainName.Location = new System.Drawing.Point(173, 128);
            this.TrainName.Name = "TrainName";
            this.TrainName.Size = new System.Drawing.Size(316, 34);
            this.TrainName.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(50, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 29);
            this.label2.TabIndex = 20;
            this.label2.Text = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(51, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "Name";
            // 
            // UpdateTrainForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(573, 450);
            this.Controls.Add(this.UpdateTrain);
            this.Controls.Add(this.TrainCapacity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TrainStatus);
            this.Controls.Add(this.TrainName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Title);
            this.Name = "UpdateTrainForm2";
            this.Text = "Update a Train";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button UpdateTrain;
        private System.Windows.Forms.TextBox TrainCapacity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TrainStatus;
        private System.Windows.Forms.TextBox TrainName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}