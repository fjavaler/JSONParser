namespace JSONParser
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
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.cmdDeserialize = new System.Windows.Forms.Button();
      this.cmdClear = new System.Windows.Forms.Button();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.textInput = new System.Windows.Forms.TextBox();
      this.textDebugOutput = new System.Windows.Forms.TextBox();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox1.Controls.Add(this.textInput);
      this.groupBox1.Location = new System.Drawing.Point(12, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(776, 264);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Raw JSON (Serialized String)";
      // 
      // cmdDeserialize
      // 
      this.cmdDeserialize.Location = new System.Drawing.Point(12, 276);
      this.cmdDeserialize.Name = "cmdDeserialize";
      this.cmdDeserialize.Size = new System.Drawing.Size(171, 55);
      this.cmdDeserialize.TabIndex = 1;
      this.cmdDeserialize.Text = "Deserialize";
      this.cmdDeserialize.UseVisualStyleBackColor = true;
      this.cmdDeserialize.Click += new System.EventHandler(this.cmdDeserialize_Click);
      // 
      // cmdClear
      // 
      this.cmdClear.Location = new System.Drawing.Point(189, 282);
      this.cmdClear.Name = "cmdClear";
      this.cmdClear.Size = new System.Drawing.Size(171, 55);
      this.cmdClear.TabIndex = 2;
      this.cmdClear.Text = "Clear Debug";
      this.cmdClear.UseVisualStyleBackColor = true;
      this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
      // 
      // groupBox2
      // 
      this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox2.Controls.Add(this.textDebugOutput);
      this.groupBox2.Location = new System.Drawing.Point(12, 343);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(776, 294);
      this.groupBox2.TabIndex = 3;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Debug Output";
      // 
      // textInput
      // 
      this.textInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textInput.Location = new System.Drawing.Point(6, 30);
      this.textInput.Multiline = true;
      this.textInput.Name = "textInput";
      this.textInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.textInput.Size = new System.Drawing.Size(764, 228);
      this.textInput.TabIndex = 4;
      // 
      // textDebugOutput
      // 
      this.textDebugOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textDebugOutput.Location = new System.Drawing.Point(6, 30);
      this.textDebugOutput.Multiline = true;
      this.textDebugOutput.Name = "textDebugOutput";
      this.textDebugOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.textDebugOutput.Size = new System.Drawing.Size(764, 258);
      this.textDebugOutput.TabIndex = 0;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 649);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.cmdClear);
      this.Controls.Add(this.cmdDeserialize);
      this.Controls.Add(this.groupBox1);
      this.Name = "Form1";
      this.Text = "JSON Parser";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button cmdDeserialize;
    private System.Windows.Forms.Button cmdClear;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.TextBox textInput;
    private System.Windows.Forms.TextBox textDebugOutput;
  }
}

