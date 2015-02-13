﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Newcourt
{
    public class Utils
    {
        #region Interface Messages

        public static DialogResult AskQuestion(String question)
        {
            return MessageBox.Show(question, Global.CompanyName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public static void ShowError(String message)
        {
            MessageBox.Show(message, Global.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
        public static void ShowException(Exception ex)
        {
            Cursor.Current = Cursors.Default;
            String message = String.Empty;

            message += ex.Message;

            if (ex.InnerException != null)
            {
                if (ex.InnerException.Message == ex.Message)
                {
                    if (ex.InnerException.InnerException != null)
                    {
                        message += String.Format(":\n{0}", ex.InnerException.InnerException.Message);
                    }
                }
                else
                {
                    message += String.Format(":\n{0}", ex.InnerException.Message);
                }
            }

            MessageBox.Show(message, Global.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowInformation(String message)
        {
            MessageBox.Show(message, Global.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        # endregion

        #region Registry

        public static Object GetRegistryValue(String keyName)
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Newcourt");

                if (key != null)
                {
                    Object obj = key.GetValue(keyName);

                    if (obj != null)
                    {
                        return obj;
                    }
                }

                return null;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static void SaveRegistryValue(String keyName, Object value)
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Software\Newcourt");

                if(key != null)
                {
                    key.SetValue(keyName, value);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        public static T GetCurrentRecord<T>(BindingSource bs)
        {
            if(bs.Current != null)
            {
                T current = (T)bs.Current;

                if (current != null)
                {
                    return current;
                }
            }

            return default(T);
        }

        public static void DisableAllControls(Control control)
        {
            // Get control recursively
            foreach(Control i in control.Controls)
            {
                DisableAllControls(i);
            }

            // Textbox
            if (control.GetType() == typeof(TextBox))
            {
                TextBox c = control as TextBox;
                c.ReadOnly = true;
            }
            // ComboBox
            else if(control.GetType() == typeof(ComboBox))
            {
                ComboBox c = control as ComboBox;
                c.Enabled = false;
            }
            // CheckBox
            else if (control.GetType() == typeof(CheckBox))
            {
                CheckBox c = control as CheckBox;
                c.Enabled = false;
            }
                // DateTimePicker
            else if (control.GetType() == typeof(DateTimePicker))
            {
                DateTimePicker c = control as DateTimePicker;
                c.Enabled = false;
            }
            // Button (Except Cancel or Close)
            else if (control.GetType() == typeof(Button))
            {
                Button c = control as Button;
                if (c.Text != "Cancel" && c.Text != "Close")
                {
                    c.Enabled = false;
                }
            }

        }
    }
}