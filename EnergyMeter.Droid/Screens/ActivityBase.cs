using System;

using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;

namespace EnergyMeter.Droid.Screens {
  public abstract class ActivityBase : Activity {
    protected override void OnCreate(Bundle bundle) {
      base.OnCreate(bundle);

      OnAfterCreate();
    }

    protected virtual bool IsRequiredCheckIfIsUserLoggedIn {
      get { return true; }
    }

    protected abstract void OnAfterCreate();


    protected virtual bool IsParamsMenuItemVisible {
      get { return false; }
    }

    public virtual bool IsBackToActivityWhichOpenedDeviceSettingsVisible {
      get { return false; }
    }


    protected void AddZeroToTextNumberIfStartWithDot(EditText editText) {
      if (editText == null) {
        return;
      }

      if (editText.Text.StartsWith(".") || editText.Text.StartsWith("-.")) {
        editText.Text = editText.Text.Replace(".", "0.");
        editText.SetSelection(editText.Text.Length);
      }
    }


    public void EnableLayoutViews(ViewGroup layout) {
      for (int i = 0; i < layout.ChildCount; i++) {
        View view = layout.GetChildAt(i);
        view.Enabled = true;

        if (view.GetType().IsSubclassOf(typeof(ViewGroup))) {
          EnableLayoutViews(view as ViewGroup);
        }

        if (view.GetType() == typeof(Button)) {
          ((Button) view).Alpha = 1.0f;
        }

        if (view.GetType() == typeof(CheckBox)) {
          ((CheckBox) view).Alpha = 1.0f;
        }
      }
    }

    public void DisableLayoutViews(ViewGroup layout) {
      for (int i = 0; i < layout.ChildCount; i++) {
        View view = layout.GetChildAt(i);
        view.Enabled = false;

        if (view.GetType().IsSubclassOf(typeof(ViewGroup))) {
          DisableLayoutViews(view as ViewGroup);
        }

        if (view.GetType() == typeof(Button)) {
          ((Button) view).Alpha = 0.3f;
        }

        if (view.GetType() == typeof(CheckBox)) {
          ((CheckBox) view).Alpha = 0.3f;
        }
      }
    }


    public void ShowMessage(string message) {
    }

    public void ShowNotPermanentMessage(string message) {
    }

    public void ShowWarning(string warning) {
    }

    public void ShowError(string error) {
    }

    public void ShowUserChoiseDialog(string question, string title, Action positiveButtonAction) {
    }

    public void ShowUserChoiseDialog(string question, string title, Action positiveButtonAction, Action negativeButtonAction) {
    }
  }
}