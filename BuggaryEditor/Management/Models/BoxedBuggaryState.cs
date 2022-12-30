﻿namespace Projects.Buggary.BuggaryEditor.Management.Models
{
    public class BoxedBuggaryState
    {
        public BoxedBuggaryState(BuggaryState initState)
        {
            this.Value = initState;
        }

        public BuggaryState Value { get; set; }
    }
}