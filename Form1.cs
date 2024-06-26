using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Globalization;
using System.Speech.Synthesis;
using System.Runtime.InteropServices;

namespace Textlow
{
    public partial class MainWindow : Form
    {
        public string currentFilePath = "";
        public string lastChanges = "";
        public OutputWindow outputWindow;

        public MainWindow()
        {
            InitializeComponent();
            outputWindow = new OutputWindow(this);
            ResetAppearance();
            ResetWindowsSettings();
            updateStatusLabel();
            updatePathDisplay();

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mainTextBox.Text != "" && mainTextBox.Text != lastChanges)
            {
                DialogResult result = MessageBox.Show("Would you like to save changes?", "Unsaved changes", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    if (!File.Exists(currentFilePath))
                    {
                        fileSaveDialog();
                    }
                    else
                    {
                        StreamWriter streamWriter = new StreamWriter(currentFilePath);
                        streamWriter.Write(mainTextBox.Text);
                        streamWriter.Close();
                    }
                    currentFilePath = "";
                    lastChanges = "";
                    mainTextBox.Clear();
                }
                else if (result == DialogResult.No)
                {
                    currentFilePath = "";
                    lastChanges = "";
                    mainTextBox.Clear();
                }
            }
            else
            {
                currentFilePath = "";
                lastChanges = "";
                mainTextBox.Clear();
            }
            updatePathDisplay();
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mainTextBox.Text != "" && mainTextBox.Text != lastChanges)
            {
                DialogResult result = MessageBox.Show("Would you like to save changes?", "Unsaved changes", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (!File.Exists(currentFilePath))
                    {
                        fileSaveDialog();
                    }
                    else
                    {
                        StreamWriter streamWriter = new StreamWriter(currentFilePath);
                        streamWriter.Write(mainTextBox.Text);
                        streamWriter.Close();
                    }
                }

            }
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select file:";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader streamReader = new StreamReader(openFileDialog.FileName))
                {
                    mainTextBox.Text = streamReader.ReadToEnd();
                    streamReader.Close();
                }
                currentFilePath = openFileDialog.FileName;
                lastChanges = mainTextBox.Text;
            }
            updatePathDisplay();
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(currentFilePath))
            {
                StreamWriter streamWriter = new StreamWriter(currentFilePath);
                streamWriter.Write(mainTextBox.Text);
                streamWriter.Close();
                lastChanges = mainTextBox.Text;
            }
            else
            {
                fileSaveDialog();
                lastChanges = mainTextBox.Text;
            }
            updatePathDisplay();
        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileSaveDialog();
            lastChanges = mainTextBox.Text;
            updatePathDisplay();
        }

        private void appendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            string aptext = "";
            openFileDialog.Title = "Select file:";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader streamReader = new StreamReader(openFileDialog.FileName))
                {
                    aptext = streamReader.ReadToEnd();
                    streamReader.Close();
                }
                mainTextBox.Text = mainTextBox.Text + aptext;
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainTextBox.Copy();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainTextBox.Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText((string)Clipboard.GetData("Text"));
                mainTextBox.Paste();
            }
            catch
            {

            }
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainTextBox.SelectAll();
        }
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainTextBox.Undo();
        }
        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainTextBox.Redo();
        }
        private void appearanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            appearanceSettingForm aps = new appearanceSettingForm(this);
            aps.Show();
        }

        private void windowsSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            windowsSettingsForm wsp = new windowsSettingsForm(this);
            wsp.Show();
        }

        private void manageExtensionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            extensionsManagementForm emf = new extensionsManagementForm();
            emf.Show();
        }


        private void base64ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TextlowEncrypter textlowEncrypter = new TextlowEncrypter();
                outputWindow.receiveData(textlowEncrypter.base64(mainTextBox.Text), "Base64 encryption");
            }
            catch (Exception exc)
            {
                outputWindow.receiveData("Error: " + exc.Message, "Base64 encryption");
            }

        }

        private void base64ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                TextlowDecrypter textlowDecrypter = new TextlowDecrypter();
                outputWindow.receiveData(textlowDecrypter.base64(mainTextBox.Text), "Base64 decryption");
            }
            catch (Exception exc)
            {
                outputWindow.receiveData("Error: " + exc.Message, "Base64 decryption");
            }

        }
        private void tripleDESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string key = "";

            if (TextlowDialogResults.InputBox("Enter key:", ref key) == DialogResult.OK)
            {
                try
                {
                    TextlowEncrypter textlowEncrypter = new TextlowEncrypter();
                    outputWindow.receiveData(textlowEncrypter.tripleDES(mainTextBox.Text, key), "TripleDES encryption (key: " + key + ")");
                }
                catch (Exception exc)
                {
                    outputWindow.receiveData("Error: " + exc.Message, "TripleDES encryption (key: " + key + ")");
                }
            }
        }

        private void tripleDESToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string key = "";
            if (TextlowDialogResults.InputBox("Enter key:", ref key) == DialogResult.OK)
            {
                try
                {
                    TextlowDecrypter textlowDecrypter = new TextlowDecrypter();
                    outputWindow.receiveData(textlowDecrypter.tripleDES(mainTextBox.Text, key), "TripleDES decryption (key: " + key + ")");
                }
                catch (Exception exc)
                {
                    outputWindow.receiveData("Error: " + exc.Message, "TripleDES decryption (key: " + key + ")");
                }
            }
        }

        private void mD5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TextlowHashes textlowHashes = new TextlowHashes();
                outputWindow.receiveData(textlowHashes.MD5(mainTextBox.Text), "MD5 Hash");
            }
            catch (Exception exc)
            {
                outputWindow.receiveData("Error: " + exc.Message, "MD5 Hash");
            }
        }

        private void sHA1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TextlowHashes textlowHashes = new TextlowHashes();
                outputWindow.receiveData(textlowHashes.SHA1(mainTextBox.Text), "SHA1 Hash");
            }
            catch (Exception exc)
            {
                outputWindow.receiveData("Error: " + exc.Message, "SHA1 Hash");
            }

        }

        private void sHA256ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TextlowHashes textlowHashes = new TextlowHashes();
                outputWindow.receiveData(textlowHashes.SHA256(mainTextBox.Text), "SHA256 Hash");
            }
            catch (Exception exc)
            {
                outputWindow.receiveData("Error: " + exc.Message, "SHA256 Hash");
            }

        }

        private void sHA384ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TextlowHashes textlowHashes = new TextlowHashes();
                outputWindow.receiveData(textlowHashes.SHA384(mainTextBox.Text), "SHA384 Hash");
            }
            catch (Exception exc)
            {
                outputWindow.receiveData("Error: " + exc.Message, "SHA384 Hash");
            }
        }

        private void sHA512ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TextlowHashes textlowHashes = new TextlowHashes();
                outputWindow.receiveData(textlowHashes.SHA512(mainTextBox.Text), "SHA512 Hash");
            }
            catch (Exception exc)
            {
                outputWindow.receiveData("Error: " + exc.Message, "SHA512 Hash");
            }
        }

        private void convertToBrainfuckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TextlowTextOperations textlowTextOperations = new TextlowTextOperations();
                outputWindow.receiveData(textlowTextOperations.TextToBrainfuck(mainTextBox.Text), "Converted to Brainfuck");
            }
            catch (Exception exc)
            {
                outputWindow.receiveData("Error: " + exc.Message, "Converted to Brainfuck");
            }
        }

        private void convertFromBrainfuckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TextlowTextOperations textlowTextOperations = new TextlowTextOperations();
                outputWindow.receiveData(textlowTextOperations.BrainfuckToText(mainTextBox.Text), "Converted from Brainfuck");
            }
            catch (Exception exc)
            {
                outputWindow.receiveData("Error: " + exc.Message, "Converted from Brainfuck");
            }

        }

        private void toUpperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            outputWindow.receiveData(mainTextBox.Text.ToUpper(), "Text to upper");
        }

        private void toLowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            outputWindow.receiveData(mainTextBox.Text.ToLower(), "Text to lower");
        }

        private void convertToBinariesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TextlowTextOperations textlowTextOperations = new TextlowTextOperations();
                outputWindow.receiveData(textlowTextOperations.TextToBinary(mainTextBox.Text), "Converted to binaries");
            }
            catch (Exception exc)
            {
                outputWindow.receiveData("Error: " + exc.Message, "Converted to binaries");
            }

        }

        private void convertFromBinariesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TextlowTextOperations textlowTextOperations = new TextlowTextOperations();
                outputWindow.receiveData(textlowTextOperations.BinaryToText(mainTextBox.Text), "Converted from binaries");
            }
            catch (Exception exc)
            {
                outputWindow.receiveData("Error: " + exc.Message, "Converted from binaries");
            }

        }

        private void textDivisionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string separator = "";
            string distance = "";
            bool backwards = false;
            if (TextlowDialogResults.DoubleInputBoxWithCheckBox("Separator:", "Distance between division:", "Backwards", ref separator, ref distance, ref backwards) == DialogResult.OK)
            {
                if (separator == "" || distance == "")
                {
                    MessageBox.Show("No text field can be empty");
                }
                else if (!distance.All(char.IsDigit))
                {
                    MessageBox.Show("The second text field must be a number");
                }
                else
                {
                    try
                    {
                        TextlowTextOperations textlowTextOperations = new TextlowTextOperations();
                        outputWindow.receiveData(textlowTextOperations.TextDivision(separator, mainTextBox.Text, int.Parse(distance), backwards), "Text division");
                    }
                    catch (Exception exc)
                    {
                        outputWindow.receiveData("Error: " + exc.Message, "Text division");
                    }

                }
            }
        }

        private void toASCIIToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                TextlowTextOperations textlowTextOperations = new TextlowTextOperations();
                outputWindow.receiveData(textlowTextOperations.TextToASCII(mainTextBox.Text), "Text to ASCII");
            }
            catch (Exception exc)
            {
                outputWindow.receiveData("Error: " + exc.Message, "Text to ASCII");
            }
        }

        private void caesarCipherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string key = "3";
            if (TextlowDialogResults.InputBox("Enter the key:", ref key) == DialogResult.OK)
            {
                if (key.All(Char.IsDigit) && key != "")
                {
                    try
                    {
                        int trueKey = int.Parse(key) % 26;
                        TextlowEncrypter textlowEncrypter = new TextlowEncrypter();
                        outputWindow.receiveData(textlowEncrypter.CaesarCipher(mainTextBox.Text, trueKey), "Caesar encryption (key: " + key + ")");
                    }
                    catch (Exception exc)
                    {
                        outputWindow.receiveData("Error: " + exc.Message, "Caesar encryption (key: " + key + ")");
                    }
                }
                else
                {
                    MessageBox.Show("The key must be a number");
                }
            }
        }

        private void caesarCipherToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string key = "3";
            if (TextlowDialogResults.InputBox("Enter the key:", ref key) == DialogResult.OK)
            {
                if (key.All(Char.IsDigit) && key != "")
                {
                    try
                    {
                        int trueKey = int.Parse(key) % 26;
                        TextlowDecrypter textlowDecrypter = new TextlowDecrypter();
                        outputWindow.receiveData(textlowDecrypter.CaesarCipher(mainTextBox.Text, trueKey), "Caesar decryption (key: " + key + ")");
                    }
                    catch (Exception exc)
                    {
                        outputWindow.receiveData("Error: " + exc.Message, "Caesar decryption (key: " + key + ")");
                    }
                }
                else
                {
                    MessageBox.Show("The key must be a number");
                }
            }
        }

        private void convertToByteArrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string separator = "";
            if (TextlowDialogResults.InputBox("Separator:", ref separator) == DialogResult.OK)
            {
                if (separator != "")
                {
                    try
                    {
                        TextlowTextOperations textlowTextOperations = new TextlowTextOperations();
                        outputWindow.receiveData(textlowTextOperations.TextToByteArray(mainTextBox.Text, separator), "Text to byte array (separator: " + separator + ")");
                    }
                    catch (Exception exc)
                    {
                        outputWindow.receiveData("Error: " + exc.Message, "Text to byte array (separator: " + separator + ")");
                    }
                }
                else
                {
                    MessageBox.Show("Separator can't be empty");
                }
            }
        }

        private void convertFromByteArrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string separator = "";
            if (TextlowDialogResults.InputBox("Separator:", ref separator) == DialogResult.OK)
            {
                if (separator != "")
                {
                    try
                    {
                        TextlowTextOperations textlowTextOperations = new TextlowTextOperations();
                        outputWindow.receiveData(textlowTextOperations.ByteArrayToText(mainTextBox.Text, separator), "Text from byte array (separator: " + separator + ")");
                    }
                    catch (Exception exc)
                    {
                        outputWindow.receiveData("Error: " + exc.Message, "Text from byte array (separator: " + separator + ")");
                    }
                }
                else
                {
                    MessageBox.Show("Separator can't be empty");
                }
            }
        }

        private void vigenereCipherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string key = "";
            if (TextlowDialogResults.InputBox("Enter the key:", ref key) == DialogResult.OK)
            {
                if (key != "" && key.All(Char.IsLetter))
                {
                    try
                    {
                        TextlowEncrypter textlowEncrypter = new TextlowEncrypter();
                        outputWindow.receiveData(textlowEncrypter.VigenereCipher(mainTextBox.Text, key), "Vigenère encryption");
                    }
                    catch (Exception exc)
                    {
                        outputWindow.receiveData("Error: " + exc.Message, "Vigenère encryption");
                    }
                }
                else
                {
                    MessageBox.Show("The key contains forbidden characters");
                }
            }
        }

        private void vigenereCipherToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string key = "";
            if (TextlowDialogResults.InputBox("Enter the key:", ref key) == DialogResult.OK)
            {
                if (key != "" && key.All(Char.IsLetter))
                {
                    try
                    {
                        TextlowDecrypter textlowDecrypter = new TextlowDecrypter();
                        outputWindow.receiveData(textlowDecrypter.VigenereCipher(mainTextBox.Text, key), "Vigenère decryption");
                    }
                    catch (Exception exc)
                    {
                        outputWindow.receiveData("Error: " + exc.Message, "Vigenère decryption");
                    }
                }
                else
                {
                    MessageBox.Show("The key contains forbidden characters");
                }
            }
        }

        private void reverseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                outputWindow.receiveData(additionalFunctions.ReverseString(mainTextBox.Text), "String reverse");
            }
            catch (Exception exc)
            {
                outputWindow.receiveData("Error: " + exc.Message, "String reverse");
            }
        }

        private void capitalizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TextlowTextOperations textlowTextOperations = new TextlowTextOperations();
                outputWindow.receiveData(textlowTextOperations.Capitalize(mainTextBox.Text), "Capitalize text");
            }
            catch (Exception exc)
            {
                outputWindow.receiveData("Error: " + exc.Message, "Capitalize text");
            }
        }

        private void convertToNATOPhoneticAlphabetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TextlowTextOperations textlowTextOperations = new TextlowTextOperations();
                outputWindow.receiveData(textlowTextOperations.TextToNATOPhoneticAlphabet(mainTextBox.Text), "Converted to NATO phonetic alphabet");
            }
            catch (Exception exc)
            {

                outputWindow.receiveData("Error: " + exc.Message, "Converted to NATO phonetic alphabet");
            }

        }

        private void convertFromNATOPhoneticAlphabetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TextlowTextOperations textlowTextOperations = new TextlowTextOperations();
                outputWindow.receiveData(textlowTextOperations.TextFromNATOPhoneticAlphabet(mainTextBox.Text), "Converted from NATO phonetic alphabet");
            }
            catch (Exception exc)
            {

                outputWindow.receiveData("Error: " + exc.Message, "Converted from NATO phonetic alphabet");
            }
        }

        

        private void replaceButton_Click(object sender, EventArgs e)
        {
            string findWhat = "";
            string replaceWith = "";
            if (TextlowDialogResults.DoubleInputBox("Find what:", "Replace with:", ref findWhat, ref replaceWith) == DialogResult.OK)
            {
                if (findWhat != "")
                {
                    try
                    {
                        string extraData = findWhat.Length + replaceWith.Length < 10 ? " (" + findWhat + " => " + replaceWith + ")" : "";
                        outputWindow.receiveData(mainTextBox.Text.Replace(findWhat, replaceWith), "Replace" + extraData);
                    }
                    catch (Exception exc)
                    {
                        outputWindow.receiveData("Error: " + exc.Message, "Replace");
                    }
                }
                else
                {
                    MessageBox.Show("First text field can't be empty");
                }
            }
        }
        private void fileSaveDialog()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save file:";
            saveFileDialog.Filter = getExtension();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                streamWriter.Write(mainTextBox.Text);
                currentFilePath = saveFileDialog.FileName;
                streamWriter.Close();
            }
        }


        public void receiveDataFromOutput(string text, bool append)
        {
            if (append)
            {
                mainTextBox.Text += text;
            }
            else
            {
                mainTextBox.Text = text;
            }

        }

        private void hideOutputWindowButton_Click(object sender, EventArgs e)
        {
            hideOutputWindowButton.Checked = !hideOutputWindowButton.Checked;
            if (hideOutputWindowButton.Checked)
            {
                outputWindow.Hide();
            }
            else
            {
                outputWindow.Show();
            }
        }

        private void mainTextBox_TextChanged(object sender, EventArgs e)
        {
            updateStatusLabel();
            findStart = 0;
            if (findTextBox.Text == "")
            {
                findTextBox.BackColor = SystemColors.Window;
            }
            else
            {
                findTextBox.BackColor = mainTextBox.Text.Contains(findTextBox.Text) ? Color.FromArgb(128, 255, 128) : Color.FromArgb(255, 128, 128);
                
            }
            
        }
        private void mainTextBox_Click(object sender, EventArgs e)
        {
            updateStatusLabel();
        }


        public void ResetAppearance()
        {
            mainTextBox.Font = Properties.Settings.Default.MainTextboxFont;
            mainTextBox.ForeColor = Properties.Settings.Default.MainTextboxForecolor;
            mainTextBox.BackColor = Properties.Settings.Default.MainTextboxBackcolor;
            outputWindow.MainTextboxForecolor = Properties.Settings.Default.MainTextboxBackcolor;
            outputWindow.MainTextboxBackcolor = Properties.Settings.Default.MainTextboxForecolor;
            mainToolBar.Dock = (DockStyle)Properties.Settings.Default.ToolbarPosition;
            if (mainToolBar.Dock == DockStyle.Bottom)
            {
                fakeStatusStrip.Dock = DockStyle.Bottom;
            }
        }

        public void ResetWindowsSettings()
        {

            outputWindow.TopMost = Properties.Settings.Default.OutputMostTop;

            outputWindow.ShowInTaskbar = Properties.Settings.Default.ShowOutputInTaskBar;

            hideOutputWindowButton.Checked = Properties.Settings.Default.RememberOutputShownHidden ? Properties.Settings.Default.OutputHidden : hideOutputWindowButton.Checked;
            if (hideOutputWindowButton.Checked)
            {
                outputWindow.Hide();
            }
            else
            {
                outputWindow.Show();
            }

            if (Properties.Settings.Default.KeepWindowsPosAndSize)
            {

                Location = Properties.Settings.Default.MainWindowPos;
                Size = Properties.Settings.Default.MainWindowSize;
                outputWindow.Location = Properties.Settings.Default.OutputWindowPos;
                outputWindow.Size = Properties.Settings.Default.OutputWindowSize;
                WindowState = Properties.Settings.Default.MainWindowMaximized ? FormWindowState.Maximized : FormWindowState.Normal;
            }
            Properties.Settings.Default.Save();
        }
        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (mainTextBox.Text != "" && mainTextBox.Text != lastChanges && Properties.Settings.Default.AskToSave)
            {
                DialogResult msgBox = MessageBox.Show("Save changes before exit?", "Exit", MessageBoxButtons.YesNoCancel);
                if (msgBox == DialogResult.Yes)
                {
                    if (File.Exists(currentFilePath))
                    {
                        StreamWriter streamWriter = new StreamWriter(currentFilePath);
                        streamWriter.Write(mainTextBox.Text);
                        streamWriter.Close();
                        lastChanges = mainTextBox.Text;
                    }
                    else
                    {
                        fileSaveDialog();
                    }
                }
                else if (msgBox == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.OutputHidden = hideOutputWindowButton.Checked;
            Properties.Settings.Default.MainWindowMaximized = WindowState == FormWindowState.Maximized;
            if (WindowState != FormWindowState.Maximized)
            {
                Properties.Settings.Default.MainWindowPos = Location;
                Properties.Settings.Default.MainWindowSize = Size;
                Properties.Settings.Default.OutputWindowPos = outputWindow.Location;
                Properties.Settings.Default.OutputWindowSize = outputWindow.Size;
            }


            Properties.Settings.Default.Save();

        }

        public string getExtension()
        {

            string[] a = new string[Properties.Settings.Default.ExtensionsList.Count];
            Properties.Settings.Default.ExtensionsList.CopyTo(a, 0);
            return "All files (*.*)|*.*|Text documents (*.txt)|*.txt" + string.Join("", a);
        }

        public void updateStatusLabel()
        {
            statusLabel.Text = "length: " + mainTextBox.Text.Length + "    lines: " + mainTextBox.Lines.Count();
            posLabel.Text = "Ln: " + (int)(1 + mainTextBox.GetLineFromCharIndex(mainTextBox.GetFirstCharIndexOfCurrentLine())) + "    Col: " + (int)(1 + mainTextBox.SelectionStart - mainTextBox.GetFirstCharIndexOfCurrentLine());
        }
        public void updatePathDisplay()
        {
            string p = currentFilePath == "" ? "(none)" : currentFilePath;
            pathLabel.Text = "Path: " + p;
        }
        private SpeechSynthesizer voice;
        private bool isReading = false;
        private void speakButton_Click(object sender, EventArgs e)
        {
            if (!isReading)
            {
                voice = new SpeechSynthesizer();
                voice.SpeakAsync(mainTextBox.Text);
                voice.SpeakCompleted += new EventHandler<SpeakCompletedEventArgs>(voice_SpeakCompleted);
                isReading = true;
            }
            else
            {
                isReading = false;
                voice.Dispose();
            }
            speakButton.Checked = isReading;
        }
        private void voice_SpeakCompleted(object sender, SpeakCompletedEventArgs e)
        {
            isReading = false;
            voice.Dispose();
            speakButton.Checked = isReading;
        }

        private void quickTextReceiveButton_Click(object sender, EventArgs e)
        {
            if (outputWindow.lastReceived != "")
            {
                mainTextBox.Text = outputWindow.lastReceived;
            }
            else
            {
                MessageBox.Show("Output window is empty");
            }
        }

        private void printSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printSettingsForm psf = new printSettingsForm(this);
            psf.Show();
        }
        string stringToPrint;
        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            int charactersOnPage = 0;
            int linesPerPage = 0;

            Font selectedFont = Properties.Settings.Default.SamePrintFontAsMW ? mainTextBox.Font : Properties.Settings.Default.PrintFont;

            e.Graphics.MeasureString(stringToPrint, selectedFont, e.MarginBounds.Size, StringFormat.GenericTypographic, out charactersOnPage, out linesPerPage);

            e.Graphics.DrawString(stringToPrint, selectedFont, Brushes.Black, e.MarginBounds, StringFormat.GenericTypographic);


            if (charactersOnPage < stringToPrint.Length)
            {
                stringToPrint = stringToPrint.Substring(charactersOnPage);
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }

        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Point pMargins = Properties.Settings.Default.PrintTextMargins;
            Size pSize = Properties.Settings.Default.DefaultPrintPaperSize;
            if (pSize.Height > (pMargins.Y * 2) && pSize.Width > (pMargins.X * 2))
            {
                try
                {
                    printDocument.DefaultPageSettings.Margins.Left = pMargins.X;
                    printDocument.DefaultPageSettings.Margins.Right = pMargins.X;
                    printDocument.DefaultPageSettings.Margins.Top = pMargins.Y;
                    printDocument.DefaultPageSettings.Margins.Bottom = pMargins.Y;
                    stringToPrint = mainTextBox.Text;
                    printDocument.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("size", pSize.Width, pSize.Height);
                    printPreviewDialog.Document = printDocument;
                    if (printPreviewDialog.ShowDialog() == DialogResult.OK)
                    {
                        printDocument.Print();
                    }
                }
                catch (Exception exc)
                {

                    MessageBox.Show("Printing has failed. Please change your print settings and try again.\nError: " + exc.Message);
                }

            }
            else
            {
                MessageBox.Show("Your print settings are invalid. Please change them and try again.\nCurrent settings:\nPaper size " + pSize.Width + " width, " + pSize.Height + " height\nMargins 2x " + pMargins.X + " horizontal, 2x " + pMargins.Y + " vertical");
            }



        }
        int findStart = 0;
        private void findButton_Click(object sender, EventArgs e)
        {
            if (findTextBox.Text != "")
            {
                try
                {
                    mainTextBox.Find(findTextBox.Text, findStart, mainTextBox.Text.Length, RichTextBoxFinds.MatchCase);
                    findStart = mainTextBox.Text.IndexOf(findTextBox.Text, findStart) + 1;
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error: " + exc.Message);
                }
            }
        }

        private void findTextBox_TextChanged(object sender, EventArgs e)
        {
            findStart = 0;
            if (findTextBox.Text == "")
            {
                findTextBox.BackColor = SystemColors.Window;
            }
            else
            {
                findTextBox.BackColor = mainTextBox.Text.Contains(findTextBox.Text) ? Color.FromArgb(128, 255, 128) : Color.FromArgb(255, 128, 128);

            }
        }

        
    }
}
