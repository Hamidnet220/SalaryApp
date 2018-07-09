using System;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace SalaryApp.Framework
{
    public class EntityEditor<TEntity>:ViewBase where TEntity:class,new()
    {
        public TEntity Entity { get; set; }

        public EntityEditor()
        {
            Entity=new TEntity();
            AddAction("تایید", btn => CloseView(dialogResult: DialogResult.OK));
            AddAction("صرفنظر",btn=> CloseView(dialogResult: DialogResult.Cancel));
        }

        protected TextBox TextBox<TProperty>(Expression<Func<TEntity, TProperty>> selector, string title)
        {
            var label=new Label();
            label.Text = title;
            var textBox=new TextBox();
            this.Controls.Add(label);
            this.Controls.Add(textBox);
            return null;
        }
    }
}
