using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatchLib
{

    public class RnDBuilding : SpaceCenterBuilding
    {
        private bool dialogOpen = false;

        protected override void OnClicked()
        {
            InputLockManager.SetControlLock(ControlTypes.KSC_ALL, "RnDBuilding");
            if (ResearchAndDevelopment.Instance != null)
            {
                GameEvents.onGUIRnDComplexSpawn.Fire();
                GameEvents.onGUIRnDComplexDespawn.Add(new EventVoid.OnEvent(this.onDialogClose));
                this.dialogOpen = true;
            }
        }
        private void onDialogClose()
	    {
		    GameEvents.onGUIRnDComplexDespawn.Remove(new EventVoid.OnEvent(this.onDialogClose));
		    this.dialogOpen = false;
		    InputLockManager.RemoveControlLock("RndBuilding");
	    }

        protected override void OnOnDestroy()
        {
            if (this.dialogOpen)
            {
                GameEvents.onGUIRnDComplexDespawn.Remove(new EventVoid.OnEvent(this.onDialogClose));
            }
        }
    }


    public class Bar
    {
        private float foo = 3.1415f;

        public float GetFoo()
        {
            return foo;
        }
    }

}
