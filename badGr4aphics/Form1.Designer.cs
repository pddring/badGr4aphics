namespace badGr4aphics
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            viewpoint3D = new GroupBox();
            renderBox = new PictureBox();
            controlsBox = new GroupBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            leftRotate = new Button();
            rightRotate = new Button();
            updateButton = new Button();
            buttonLoad = new Button();
            viewpoint3D.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)renderBox).BeginInit();
            controlsBox.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // viewpoint3D
            // 
            viewpoint3D.Controls.Add(renderBox);
            viewpoint3D.Dock = DockStyle.Fill;
            viewpoint3D.Location = new Point(0, 0);
            viewpoint3D.Name = "viewpoint3D";
            viewpoint3D.Size = new Size(800, 450);
            viewpoint3D.TabIndex = 0;
            viewpoint3D.TabStop = false;
            viewpoint3D.Text = "3D Viewpoint";
            // 
            // renderBox
            // 
            renderBox.Dock = DockStyle.Fill;
            renderBox.Location = new Point(3, 19);
            renderBox.Name = "renderBox";
            renderBox.Size = new Size(794, 428);
            renderBox.TabIndex = 0;
            renderBox.TabStop = false;
            // 
            // controlsBox
            // 
            controlsBox.Controls.Add(flowLayoutPanel1);
            controlsBox.Dock = DockStyle.Bottom;
            controlsBox.Location = new Point(0, 320);
            controlsBox.Name = "controlsBox";
            controlsBox.Size = new Size(800, 130);
            controlsBox.TabIndex = 1;
            controlsBox.TabStop = false;
            controlsBox.Text = "Controls";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(leftRotate);
            flowLayoutPanel1.Controls.Add(rightRotate);
            flowLayoutPanel1.Controls.Add(updateButton);
            flowLayoutPanel1.Controls.Add(buttonLoad);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 19);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(794, 108);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // leftRotate
            // 
            leftRotate.Location = new Point(3, 3);
            leftRotate.Name = "leftRotate";
            leftRotate.Size = new Size(76, 30);
            leftRotate.TabIndex = 0;
            leftRotate.Text = "Left";
            leftRotate.UseVisualStyleBackColor = true;
            leftRotate.Click += leftRotate_Click;
            // 
            // rightRotate
            // 
            rightRotate.Location = new Point(85, 3);
            rightRotate.Name = "rightRotate";
            rightRotate.Size = new Size(76, 30);
            rightRotate.TabIndex = 1;
            rightRotate.Text = "Right";
            rightRotate.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(167, 3);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(84, 30);
            updateButton.TabIndex = 2;
            updateButton.Text = "&Refresh";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(257, 3);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(77, 30);
            buttonLoad.TabIndex = 3;
            buttonLoad.Text = "Load";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(controlsBox);
            Controls.Add(viewpoint3D);
            Name = "Form1";
            Text = "Graphics Window";
            Load += Form1_Load;
            viewpoint3D.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)renderBox).EndInit();
            controlsBox.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox viewpoint3D;
        private GroupBox controlsBox;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button leftRotate;
        private Button rightRotate;
        private PictureBox renderBox;
        private Button updateButton;
        private Button buttonLoad;
    }
}