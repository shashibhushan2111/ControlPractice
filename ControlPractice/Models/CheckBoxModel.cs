namespace ControlPractice.Models
{
    public class CheckBoxModel
    {
        public int Value { get; set; }
        public string Text { get; set; }
        public bool IsChecked { get; set; }
    }
    public class CheckBoxList
    {
        public List<CheckBoxModel> CheckBoxItems { get; set; }
    }
}
