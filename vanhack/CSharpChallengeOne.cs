using System.Text;

namespace vanhack // Note: actual namespace depends on the project name.
{
    public class CSharpChallengeOne
    {
        public List<List<string>> ParseCsv(
            string csv,
            string separator = ",",
            string quote = "\""
        )
        {
            var rows = new List<List<string>>();

            if (csv.Length == 0)
            {
                rows.Add(new List<string> { "" });
                return rows;
            }

            var currentRow = new List<string>();
            var currentField = new StringBuilder();
            var inQuotedField = false;

            for (int i = 0; i < csv.Length; i++)
            {
                var currentChar = csv[i];
                var nextChar = i < csv.Length - 1 ? csv[i + 1] : '\0';

                if (currentChar == quote[0])
                {
                    if (inQuotedField)
                    {
                        if (nextChar == quote[0])
                        {
                            // escaped quote character
                            currentField.Append(quote[0]);
                            i++;
                        }
                        else
                        {
                            // end of quoted field
                            inQuotedField = false;
                        }
                    }
                    else
                    {
                        // start of quoted field
                        inQuotedField = true;
                    }
                }
                else if (currentChar == separator[0] && !inQuotedField)
                {
                    // end of field
                    currentRow.Add(currentField.ToString());
                    currentField.Clear();
                }
                else if (currentChar == '\n' && !inQuotedField)
                {
                    // end of row
                    currentRow.Add(currentField.ToString());
                    currentField.Clear();
                    rows.Add(currentRow);
                    currentRow = new List<string>();
                }
                else
                {
                    // part of field value
                    currentField.Append(currentChar);
                }
            }

            // add last field and row if necessary
            if (currentField.Length > 0 || currentRow.Count > 0)
            {
                currentRow.Add(currentField.ToString());
                rows.Add(currentRow);
            }

            return rows;
        }
    }
}