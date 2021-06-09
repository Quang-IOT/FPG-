package com.example.remoteir;

import androidx.appcompat.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;


import android.widget.Button; import android.widget.EditText; import android.widget.Toast;

import com.google.firebase.database.DatabaseReference; import com.google.firebase.database.FirebaseDatabase;

public class hengio extends AppCompatActivity { EditText edtgio,edtphut,edtbt1,edtbt2;
    Button btnEnter; FirebaseDatabase csdl2;
    DatabaseReference gio,phut,lenh1,lenh2; @Override
    protected void onCreate(Bundle savedInstanceState) { super.onCreate(savedInstanceState); setContentView(R.layout.activity_hengio);
        csdl2 = FirebaseDatabase.getInstance(); edtbt1=(EditText) findViewById(R.id.editTextlenh1); edtbt2=(EditText) findViewById(R.id.editTextlenh2); edtgio=(EditText) findViewById(R.id.editTexthour); edtphut=(EditText) findViewById(R.id.editTextminute); btnEnter=(Button) findViewById(R.id.buttonEnter);

        gio = csdl2.getReference("gio"); phut = csdl2.getReference("phut");
        lenh1 = csdl2.getReference("nutnhan1"); lenh2 = csdl2.getReference("nutnhan2");

        btnEnter.setOnClickListener(new View.OnClickListener() { @Override
        public void onClick(View v) {
            String hg= edtgio.getText().toString().trim(); String hp= edtphut.getText().toString().trim();

            String b1= edtbt1.getText().toString().trim(); String b2= edtbt2.getText().toString().trim();
//Toast.makeText(hengio.this,"Please,set hour",Toast.LENGTH_SHORT).show();
            if(hg.length()==0)
            {
                Toast.makeText(hengio.this,"Please,set hour",Toast.LENGTH_SHORT).show();
                edtgio.requestFocus();
            }
            else if(hp.length()==0)
            {
                Toast.makeText(hengio.this,"Please,setminute",Toast.LENGTH_SHORT).show();
                edtphut.requestFocus();
            }
            else if(b1.length()==0 && b2.length()==0)
            {
                Toast.makeText(hengio.this,"Please,set button",Toast.LENGTH_SHORT).show();
                edtbt1.requestFocus();
            }
            else if(b1.length()!=0 && b2.length()==0)
            {
                int gg=Integer.parseInt(hg); int pp=Integer.parseInt(hp); if (gg>=24)
            {
                Toast.makeText(hengio.this,"Please,Hour value <24 ",Toast.LENGTH_SHORT).show();
                edtgio.setText("");

                edtgio.requestFocus();
            }
            else if (pp>=60)
            {
                edtphut.setText(""); Toast.makeText(hengio.this,"Please, Minute value < 60",Toast.LENGTH_SHORT).show();

                    edtphut.requestFocus();
            }
            else {
                gio.setValue(hg); phut.setValue(hp); lenh1.setValue(b1); lenh2.setValue(" ");
                Toast.makeText(hengio.this, "Complete for 1 command", Toast.LENGTH_SHORT).show();
            }

            }
            else if(b1.length()==0 && b2.length()!=0)
            {
                gio.setValue(hg); phut.setValue(hp);

                lenh1.setValue(" "); lenh2.setValue(b2);
                Toast.makeText(hengio.this,"Complete for 1 command",Toast.LENGTH_SHORT).show();
            }
            else
            {
                gio.setValue(hg); phut.setValue(hp); lenh1.setValue(b1); lenh2.setValue(b2);
                Toast.makeText(hengio.this,"Complete for 2 command",Toast.LENGTH_SHORT).show();
            }

        }
        });
    }

}

