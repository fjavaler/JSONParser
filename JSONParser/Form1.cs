using System;
using System.Diagnostics;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace JSONParser
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    #region UI Events

    private void cmdClear_Click(object sender, EventArgs e)
    {
      textDebugOutput.Text = string.Empty;
    }

    private void cmdDeserialize_Click(object sender, EventArgs e)
    {
      //DebugOutput(textInput.Text);
      DeserializeJson(textInput.Text);
    }

    #endregion

    #region JSON Functions

    private void DeserializeJson(string strJson)
    {
      try
      {
        // Cases: Leave only one uncommented at a time to test
        //var jPerson = JsonConvert.DeserializeObject<dynamic>(strJson);
        //JSONPersonSimple jPerson = JsonConvert.DeserializeObject<JSONPersonSimple>(strJson);
        //JSONPersonComplex jPerson = JsonConvert.DeserializeObject<JSONPersonComplex>(strJson);
        JSONPersonArray jPerson = JsonConvert.DeserializeObject<JSONPersonArray>(strJson);

        DebugOutput("Here's our JSON object: " + Environment.NewLine + Environment.NewLine + jPerson.ToString());

        DebugOutput(Environment.NewLine + "Here's the first name: " + Environment.NewLine + Environment.NewLine + jPerson.firstname);
        
        // Only works with JSONPersonComplex, not simple or dynamic. Comment if necessary
        DebugOutput(Environment.NewLine + "Here's the street address: " + Environment.NewLine + Environment.NewLine + jPerson.address);
        DebugOutput(Environment.NewLine + "Here's the city: " + Environment.NewLine + Environment.NewLine + jPerson.address.city);

        // Only works with JSONPersonArray, not simple, dynamic, or JSONPersonComplex. Comment if necessary
        DebugOutput("Attempting to print phone numbers...");
        foreach (var number in jPerson.phoneNumbers)
        {
          DebugOutput(number.type.ToString() + " - " + number.number.ToString());
        }
      }
      catch (Exception ex)
      {
        DebugOutput("We had a problem: " + ex.Message.ToString());
      }
    }

    #endregion

    #region Debug OutPut

    private void DebugOutput(string strDebugText)
    {
      try
      {
        System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
        textDebugOutput.Text = textDebugOutput.Text + strDebugText + Environment.NewLine;
        textDebugOutput.SelectionStart = textDebugOutput.TextLength;
        textDebugOutput.ScrollToCaret();
      }
      catch (Exception ex)
      {
        System.Diagnostics.Debug.Write(ex.Message.ToString() + Environment.NewLine);
      }
    }

    #endregion
  }
}
