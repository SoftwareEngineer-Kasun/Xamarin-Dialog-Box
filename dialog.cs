button.Click += delegate { 
      AlertDialog.Builder alertDiag = new AlertDialog.Builder(this); 
      alertDiag.SetTitle("Confirm delete"); 
      alertDiag.SetMessage("Once deleted the move cannot be undone"); 
      alertDiag.SetPositiveButton("Delete", (senderAlert, args) => { 
         Toast.MakeText(this, "Deleted", ToastLength.Short).Show();
      }); 
      alertDiag.SetNegativeButton("Cancel", (senderAlert, args) => { 
         alertDiag.Dispose(); 
      }); 
      Dialog diag = alertDiag.Create(); 
      diag.Show(); 
   }; 
