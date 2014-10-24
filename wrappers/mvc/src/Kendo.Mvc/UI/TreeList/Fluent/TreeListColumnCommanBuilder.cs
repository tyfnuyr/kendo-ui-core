namespace Kendo.Mvc.UI.Fluent
{
    using System.Collections.Generic;
    using System.Collections;
    using System;
    using Kendo.Mvc.Extensions;

    /// <summary>
    /// Defines the fluent API for configuring the TreeListColumnComman settings.
    /// </summary>
    public class TreeListColumnCommanBuilder: IHideObjectMembers
    {
        private readonly TreeListColumnComman container;

        public TreeListColumnCommanBuilder(TreeListColumnComman settings)
        {
            container = settings;
        }

        //>> Fields
        
        /// <summary>
        /// The name of the command. The built-in commands are "edit", "createchild" and "destroy". Can be set to a custom value.
        /// </summary>
        /// <param name="value">The value that configures the name.</param>
        public TreeListColumnCommanBuilder Name(string value)
        {
            container.Name = value;

            return this;
        }
        
        /// <summary>
        /// The text displayed by the command button. If not set the name option is used as the button text.
        /// </summary>
        /// <param name="value">The value that configures the text.</param>
        public TreeListColumnCommanBuilder Text(string value)
        {
            container.Text = value;

            return this;
        }
        
        /// <summary>
        /// The CSS class applied to the command button.
        /// </summary>
        /// <param name="value">The value that configures the classname.</param>
        public TreeListColumnCommanBuilder ClassName(string value)
        {
            container.ClassName = value;

            return this;
        }
        
        /// <summary>
        /// The JavaScript function executed when the user clicks the command button. The function receives a jQuery Event as an argument.The function context (available via the this keyword) will be set to the grid instance.
        /// </summary>
        /// <param name="value">The value that configures the click.</param>
        public TreeListColumnCommanBuilder Click(string value)
        {
            container.Click = value;

            return this;
        }
        
        //<< Fields
    }
}

