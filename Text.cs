using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Text_Processor
{
    internal class Text
    {
        Form1 f;

        Regex c, are, you, w;

        public static string[]? arr;
        public static List<string>? wordList;
        public static List<string>? uniqueList;
        public static List<string> list = new List<string>();
        public static List<string> _list = new List<string>();

        public static string? str;

        public Text(Form1 f)
        {
            this.f = f;
        }

        public void Distinct()
        {
            wordList = f.rtxtWord.Text.Split('\n').ToList();
            uniqueList = wordList.Distinct().ToList();
            f.rtxtWord.Clear();
            f.rtxtWord.Lines = uniqueList.ToArray();

            f.rtxtRemoved.Clear();
            list = wordList.GroupBy(x => x)
              .Where(g => g.Count() > 1)
              .Select(y => y.Key)
              .ToList();

            f.rtxtRemoved.Clear();
            f.rtxtRemoved.Lines = list.ToArray();

            if (wordList != null)
            {
                wordList.Clear();
            }
            if (list != null)
            {
                list.Clear();
            }
            if (_list != null)
            {
                _list.Clear();
            }
            if (uniqueList != null)
            {
                uniqueList.Clear();
            }
        }

        public void Sort()
        {
            wordList = f.rtxtWord.Text.Split('\n').ToList();
            wordList.Sort();
            f.rtxtWord.Clear();
            f.rtxtWord.Lines = wordList.ToArray();

            if (wordList != null)
            {
                wordList.Clear();
            }
            if (list != null)
            {
                list.Clear();
            }
            if (_list != null)
            {
                _list.Clear();
            }
            if (uniqueList != null)
            {
                uniqueList.Clear();
            }
        }

        public void Variation()
        {
            wordList = f.rtxtWord.Text.Split('\n').ToList();

            foreach (var line in wordList)
            {
                c = new Regex(@"('s)");
                Match m = c.Match(line);
                if (m.Success)
                {
                    str = line;
                    list.Add(str);
                    str = line.Replace(m.Value, "");
                    list.Add(str);
                    str = line.Replace(m.Value, "s");
                    list.Add(str);
                    str = line.Replace(m.Value, " is");
                    list.Add(str);
                }
            }
            foreach (var line in wordList)
            {
                arr = line.Split(' ').ToArray();
                are = new Regex(@"((\sare))");
                Match m = are.Match(line);
                if (m.Success)
                {
                    str = line.Replace(m.Value, " r");
                    list.Add(str);
                }
                if (arr[0].Equals("are"))
                {
                    str = line.Replace(arr[0], "r");
                    list.Add(str);
                }
                you = new Regex(@"((\syou))");
                Match m2 = you.Match(line);
                if (m2.Success)
                {
                    str = line.Replace(m2.Value, " u");
                    list.Add(str);
                }
                if (arr[0].Equals("you"))
                {
                    str = line.Replace(arr[0], "u");
                    list.Add(str);
                }
                else if (arr[0].Equals("your"))
                {
                    str = line.Replace(arr[0], "ur");
                    list.Add(str);
                }
                if (m.Success && m2.Success)
                {
                    str = line.Replace(m.Value, " r");
                    string _str = str.Replace(m2.Value, " u");
                    list.Add(_str);
                }
            }
            foreach (var line in list)
            {
                are = new Regex(@"((\sare))");
                Match m = are.Match(line);
                if (m.Success)
                {
                    str = line.Replace(m.Value, " r");
                    _list.Add(str);
                }

                you = new Regex(@"((\syou))");
                Match m2 = you.Match(line);
                if (m2.Success)
                {
                    str = line.Replace(m2.Value, " u");
                    _list.Add(str);
                }

                if (m.Success && m2.Success)
                {
                    str = line.Replace(m.Value, " r");
                    string _str = str.Replace(m2.Value, " u");
                    _list.Add(_str);
                }
            }

            foreach (var line in _list)
            {
                wordList.Add(line);
            }

            foreach (var line in list)
            {
                wordList.Add(line);
            }

            uniqueList = wordList.Distinct().ToList();

            f.rtxtWord.Clear();
            uniqueList.Sort();
            f.rtxtWord.Lines = uniqueList.ToArray();

            if (wordList != null)
            {
                wordList.Clear();
            }
            if (list != null)
            {
                list.Clear();
            }
            if (_list != null)
            {
                _list.Clear();
            }
            if (uniqueList != null)
            {
                uniqueList.Clear();
            }
        }

        public void RegexWord(bool rChecked, bool aChecked)
        {
            if (rChecked)
            {
                wordList = f.rtxtWord.Text.Split('\n').ToList();
                _list = f.rtxtWord.Text.Split('\n').ToList();
                if (f.txtRegex.Text != string.Empty && f.txtWord.Text != string.Empty)
                {
                    string strRegex = f.txtRegex.Text;
                    string strWord = f.txtWord.Text;

                    foreach (var line in wordList)
                    {
                        w = new Regex($@"({strRegex})");
                        Match m = w.Match(line);
                        if (m.Success)
                        {
                            if (_list.Contains(line))
                            {
                                _list.Remove(line);
                            }
                            str = line;
                            str = Regex.Replace(str, $@"{strRegex}", $@"{strWord}");
                            _list.Add(str);
                        }
                    }

                    f.rtxtWord.Clear();
                    f.rtxtWord.Lines = _list.ToArray();

                    if (wordList != null)
                    {
                        wordList.Clear();
                    }
                    if (list != null)
                    {
                        list.Clear();
                    }
                    if (_list != null)
                    {
                        _list.Clear();
                    }
                    if (uniqueList != null)
                    {
                        uniqueList.Clear();
                    }
                }
                else if (f.txtRegex.Text == string.Empty || f.txtWord.Text == string.Empty)
                {
                    MessageBox.Show("\"Regex\" AND \"Word\" must be filled!");
                }
            }
            else if (aChecked)
            {
                wordList = f.rtxtWord.Text.Split('\n').ToList();
                _list = f.rtxtWord.Text.Split('\n').ToList();
                if (f.txtRegex.Text != string.Empty && f.txtWord.Text != string.Empty)
                {
                    string strRegex = f.txtRegex.Text;
                    string strWord = f.txtWord.Text;

                    foreach (var line in wordList)
                    {
                        w = new Regex($@"({strRegex})");
                        Match m = w.Match(line);
                        if (m.Success)
                        {
                            str = line;
                            str = Regex.Replace(str, $@"{strRegex}", $@"{strWord}");
                            list.Add(str);
                        }
                    }
                    foreach (var line in list)
                    {
                        _list.Add(line);
                    }
                    f.rtxtWord.Clear();

                    f.rtxtWord.Lines = _list.ToArray();

                    if (wordList != null)
                    {
                        wordList.Clear();
                    }
                    if (list != null)
                    {
                        list.Clear();
                    }
                    if (_list != null)
                    {
                        _list.Clear();
                    }
                    if (uniqueList != null)
                    {
                        uniqueList.Clear();
                    }
                }
                else if (f.txtRegex.Text == string.Empty || f.txtWord.Text == string.Empty)
                {
                    MessageBox.Show("\"Regex\" AND \"Word\" must be filled!");
                }
            }
        }

        public void SaveAs()
        {
            wordList = f.rtxtWord.Text.Split('\n').ToList();

            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Title = "Save";
            saveDialog.Filter = "Text Files (*.txt)|*.txt" + "|" +
                                "All Files (*.*)|*.*";
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                using (var sw = File.AppendText(saveDialog.FileName))
                {
                    foreach (var line in wordList)
                    {
                        sw.WriteLine(line);
                    }

                    sw.Close();
                }
            }
        }

        public void TextBoxClear()
        {
            if (wordList != null)
            {
                wordList.Clear();
            }
            if (list != null)
            {
                list.Clear();
            }
            if (_list != null)
            {
                _list.Clear();
            }
            if (uniqueList != null)
            {
                uniqueList.Clear();
            }

            f.txtRegex.Clear();
            f.txtWord.Clear();
        }

        public void RemovedDuplicates()
        {
            if (wordList != null)
            {
                wordList.Clear();
            }
            if (list != null)
            {
                list.Clear();
            }
            if (_list != null)
            {
                _list.Clear();
            }
            if (uniqueList != null)
            {
                uniqueList.Clear();
            }

            f.rtxtRemoved.Clear();
        }

        public void Clear()
        {
            if (wordList != null)
            {
                wordList.Clear();
            }
            if (list != null)
            {
                list.Clear();
            }
            if (_list != null)
            {
                _list.Clear();
            }
            if (uniqueList != null)
            {
                uniqueList.Clear();
            }

            f.rtxtWord.Clear();
        }

        public void LineCount()
        {
            var lineCount = f.rtxtWord.Lines.Count();
            f.lblLineCount.Text = lineCount.ToString();
        }
    }
}
