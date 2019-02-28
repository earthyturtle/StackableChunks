using System;
using Verse;

namespace StackableChunks {
    public class Chunk : Thing {
        public override void ExposeData() {
            base.ExposeData();
            Scribe_Values.Look<int>(ref this.stackCount, "stackCount", 0, true);
        }
    }
}
