﻿namespace BackEnd.Data
{
    using BackEnd.Migrations;
    using System.Collections.Generic;

    public class Watcher : WorkflowDTO.Watcher
    {
        public virtual ICollection<TeamWatcher> TeamWatchers { get; set; }
        
        public virtual ICollection<AssignmentWatcher> AssignmentWatchers { get; set; }
    }
}
