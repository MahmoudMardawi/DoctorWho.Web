﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Domain.Models
{
    public class Companion
    {
        public Companion()
        {
            this.EpisodeCompanions = new List<EpisodeCompanion>();
        }
        public Companion(string CompanionName, string WhoPlayed) : this()
        {
            this.CompanionName = CompanionName;
            this.WhoPlayed = WhoPlayed;
        }
        public int CompanionId { get; set; }
        public string CompanionName { get; set; }
        public string WhoPlayed { get; set; }
        public List<EpisodeCompanion> EpisodeCompanions { get; set; }
    }
}
