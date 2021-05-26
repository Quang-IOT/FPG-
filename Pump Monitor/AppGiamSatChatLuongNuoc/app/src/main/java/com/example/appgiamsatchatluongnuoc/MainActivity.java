package com.example.appgiamsatchatluongnuoc;

import androidx.appcompat.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageButton;
import android.widget.ImageView;
import android.widget.ListView;
import android.widget.RadioButton;
import android.widget.RadioGroup;
import android.widget.TextView;
import android.widget.Toast;
import com.google.firebase.database.DataSnapshot;
import com.google.firebase.database.DatabaseError;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;
import com.google.firebase.database.ValueEventListener;


public class MainActivity extends AppCompatActivity {
    TextView txtddn,txtndn,txtdmn,txtName,txtns,txtmasv,txtgvhd;
    ArrayAdapter<String> adapter;
    DatabaseReference Do_Duc_Nuoc,Do_Man_Nuoc,Nhiet_Do_Nuoc;
    String TAG="FIREBASE";
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        anhxa();
        DatabaseReference database = FirebaseDatabase.getInstance().getReference();
/*        Do_Duc_Nuoc = database.child("Do Duc Nuoc");
        Do_Man_Nuoc = database.child("Do Man Nuoc");
        Nhiet_Do_Nuoc = database.child("Nhiet Do Nuoc");*/

        database.addValueEventListener(new ValueEventListener() {
            @Override
            public void onDataChange(DataSnapshot dataSnapshot) {
//vòng lặp để lấy dữ liệu khi có sự thay đổi trên Firebase
                for (DataSnapshot data: dataSnapshot.getChildren())
                {
//lấy key của dữ liệu
                    String key =data.getKey();

                    if (key.equals("Do Duc Nuoc")) {

                        txtddn.setText(data.getValue().toString());

                    }
                    if (key.equals("Do Man Nuoc")) {

                        txtndn.setText(data.getValue().toString());

                    }
                    if (key.equals("Nhiet Do Nuoc")) {

                        txtdmn.setText(data.getValue().toString());

                    }

                }
            }
            @Override
            public void onCancelled(DatabaseError databaseError) {
                Log.w(TAG, "loadPost:onCancelled", databaseError.toException());
            }
        });

        txtName.setText("Tên sinh viên:");
        txtmasv.setText("Mã SV:");
        txtgvhd.setText("GVHD: ");
    }

    private void anhxa()
    {
        txtddn = findViewById(R.id.txtddn);
        txtndn = findViewById(R.id.txtndn);
        txtdmn = findViewById(R.id.txtdmn);
        txtName = (TextView)findViewById(R.id.txtName);
        txtmasv = (TextView)findViewById(R.id.txtmasv);
        txtgvhd = (TextView)findViewById(R.id.txtGV);
    }

}

