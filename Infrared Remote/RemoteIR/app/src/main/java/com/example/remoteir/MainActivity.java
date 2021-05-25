package com.example.remoteir;

import android.content.Intent;
import androidx.appcompat.app.AppCompatActivity;
import android.os.Bundle;
import android.view.MotionEvent;
import android.view.View;
import android.widget.Button;
import android.widget.CompoundButton;
import android.widget.Switch;
import android.widget.Toast;


import android.os.Bundle;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;
public class MainActivity extends AppCompatActivity {
    Button bt1,bt2,bt3,bt4,bt5,bt6,bt7,bt8,bt9,bt10,bt11,bt12,bt13,bt14,bt15,bt16,bt17,bt18,bt19
            ,bt20,bt21,bt22,bt23,bt24,bthengio;
    Switch sw2;
    FirebaseDatabase csdl;
    DatabaseReference  on1,on2,on3,on4,up,dw,next,back,b0,b1,b2,b3,b4,b5,b6,b7,b8,b9,bsao,bthang,mode
            ,menu,exit,mute,set;
    int ks=0,krs=0;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        anhxa();
        csdl = FirebaseDatabase.getInstance();
//        on1 = csdl.getReference("TT_NUT_ON_1");
//        on2 = csdl.getReference("TT_NUT_ON_2");
//        on3 = csdl.getReference("TT_NUT_ON_3");
//        on4 = csdl.getReference("TT_NUT_ON_4");
//        up = csdl.getReference("TT_UP");
//        dw = csdl.getReference("TT_DW");
//        next = csdl.getReference("TT_NEXT");
//        back = csdl.getReference("TT_BACK");
//        b0 = csdl.getReference("NUT_0");
        b1 = csdl.getReference("DATA/NUT_01");
        b2 = csdl.getReference("DATA/NUT_02");
        b3 = csdl.getReference("DATA/NUT_03");
        b4 = csdl.getReference("DATA/NUT_04");
        b5 = csdl.getReference("DATA/NUT_05");
        b6 = csdl.getReference("DATA/NUT_06");
        b7 = csdl.getReference("DATA/NUT_07");
        b8 = csdl.getReference("DATA/NUT_08");
        b9 = csdl.getReference("DATA/NUT_09");
//        bsao = csdl.getReference("TT_SAO");
//        bthang = csdl.getReference("TT_THANG");
//        mode = csdl.getReference("TT_MODE");
//        menu = csdl.getReference("TT_MENU");
//        exit = csdl.getReference("TT_EXIT");
//        mute = csdl.getReference("TT_MUTE");
        set = csdl.getReference("SETUP/MODE");
        bt1.setOnTouchListener(new View.OnTouchListener() {
            @Override
            public boolean onTouch(View v, MotionEvent event) {
                if(event.getAction()==MotionEvent.ACTION_DOWN)
                {
                    on1.setValue("1");
                }
                else if(event.getAction()==MotionEvent.ACTION_UP)
                {
                    on1.setValue("0");
                }
                return false;
            }
        });
        bt2.setOnTouchListener(new View.OnTouchListener() {
            @Override
            public boolean onTouch(View v, MotionEvent event) {
                if(event.getAction()==MotionEvent.ACTION_DOWN)
                {
                    on2.setValue("1");
                }
                else if(event.getAction()==MotionEvent.ACTION_UP)
                {on2.setValue("0");
                }
                return false;
            }
        });
        bt3.setOnTouchListener(new View.OnTouchListener() {
            @Override
            public boolean onTouch(View v, MotionEvent event) {
                if(event.getAction()==MotionEvent.ACTION_DOWN)
                {
                    on3.setValue("1");
                }
                else if(event.getAction()==MotionEvent.ACTION_UP)
                {
                    on3.setValue("0");
                }
                return false;
            }
        });
        bt4.setOnTouchListener(new View.OnTouchListener() {
            @Override
            public boolean onTouch(View v, MotionEvent event) {
                if(event.getAction()==MotionEvent.ACTION_DOWN)
                {
                    on4.setValue("1");
                }
                else if(event.getAction()==MotionEvent.ACTION_UP)
                {
                    on4.setValue("0");
                }
                return false;
            }
        });
        bt5.setOnTouchListener(new View.OnTouchListener() {
            @Override
            public boolean onTouch(View v, MotionEvent event) {
                if(event.getAction()==MotionEvent.ACTION_DOWN)
                {
                    up.setValue("1");
                }
                else if(event.getAction()==MotionEvent.ACTION_UP)
                {up.setValue("0");
                }
                return false;
            }
        });
        bt6.setOnTouchListener(new View.OnTouchListener() {
            @Override
            public boolean onTouch(View v, MotionEvent event) {
                if(event.getAction()==MotionEvent.ACTION_DOWN)
                {
                    dw.setValue("1");
                }
                else if(event.getAction()==MotionEvent.ACTION_UP)
                {
                    dw.setValue("0");
                }
                return false;
            }
        });
        bt7.setOnTouchListener(new View.OnTouchListener() {
            @Override
            public boolean onTouch(View v, MotionEvent event) {
                if(event.getAction()==MotionEvent.ACTION_DOWN)
                {
                    next.setValue("1");
                }
                else if(event.getAction()==MotionEvent.ACTION_UP)
                {
                    next.setValue("0");
                }
                return false;
            }
        });
        bt8.setOnTouchListener(new View.OnTouchListener() {
            @Override
            public boolean onTouch(View v, MotionEvent event) {
                if(event.getAction()==MotionEvent.ACTION_DOWN)
                {
                    back.setValue("1");
                }
                else if(event.getAction()==MotionEvent.ACTION_UP)
                {back.setValue("0");
                }
                return false;
            }
        });
        bt9.setOnTouchListener(new View.OnTouchListener() {
            @Override
            public boolean onTouch(View v, MotionEvent event) {
                if(event.getAction()==MotionEvent.ACTION_DOWN)
                {
                    menu.setValue("1");
                }
                else if(event.getAction()==MotionEvent.ACTION_UP)
                {
                    menu.setValue("0");
                }
                return false;
            }
        });
        bt10.setOnTouchListener(new View.OnTouchListener() {
            @Override
            public boolean onTouch(View v, MotionEvent event) {
                if(event.getAction()==MotionEvent.ACTION_DOWN)
                {
                    mute.setValue("1");
                }
                else if(event.getAction()==MotionEvent.ACTION_UP)
                {
                    mute.setValue("0");
                }
                return false;
            }
        });
        bt11.setOnTouchListener(new View.OnTouchListener() {
            @Override
            public boolean onTouch(View v, MotionEvent event) {
                if(event.getAction()==MotionEvent.ACTION_DOWN)
                {
                    exit.setValue("1");
                }
                else if(event.getAction()==MotionEvent.ACTION_UP)
                {exit.setValue("0");
                }
                return false;
            }
        });
        bt12.setOnTouchListener(new View.OnTouchListener() {
            @Override
            public boolean onTouch(View v, MotionEvent event) {
                if(event.getAction()==MotionEvent.ACTION_DOWN)
                {
                    mode.setValue("1");
                }
                else if(event.getAction()==MotionEvent.ACTION_UP)
                {
                    mode.setValue("0");
                }
                return false;
            }
        });
        bt13.setOnTouchListener(new View.OnTouchListener() {
            @Override
            public boolean onTouch(View v, MotionEvent event) {
                if(event.getAction()==MotionEvent.ACTION_DOWN)
                {
                    b0.setValue("1");
                }
                else if(event.getAction()==MotionEvent.ACTION_UP)
                {
                    b0.setValue("0");
                }
                return false;
            }
        });
        bt14.setOnTouchListener(new View.OnTouchListener() {
            @Override
            public boolean onTouch(View v, MotionEvent event) {
                if(event.getAction()==MotionEvent.ACTION_DOWN)
                {
                    b1.setValue("1");
                    try
                    {
                        Thread.sleep(3000);
                    }
                    catch(Exception e)
                    {
                    }
                }
                else if(event.getAction()==MotionEvent.ACTION_UP)
                {b1.setValue("0");
                }
                return false;
            }
        });
        bt15.setOnTouchListener(new View.OnTouchListener() {
            @Override
            public boolean onTouch(View v, MotionEvent event) {
                if(event.getAction()==MotionEvent.ACTION_DOWN)
                {
                    b2.setValue("1");
                    try
                    {
                        Thread.sleep(3000);
                    }
                    catch(Exception e)
                    {
                    }
                }
                else if(event.getAction()==MotionEvent.ACTION_UP)
                {
                    b2.setValue("0");
                }
                return false;
            }
        });
        bt16.setOnTouchListener(new View.OnTouchListener() {
            @Override
            public boolean onTouch(View v, MotionEvent event) {
                if(event.getAction()==MotionEvent.ACTION_DOWN)
                {
                    b3.setValue("1");
                    try
                    {
                        Thread.sleep(3000);
                    }
                    catch(Exception e)
                    {
                    }
                }
                else if(event.getAction()==MotionEvent.ACTION_UP)
                {
                    b3.setValue("0");
                }
                return false;
            }
        });
        bt17.setOnTouchListener(new View.OnTouchListener() {
            @Override
            public boolean onTouch(View v, MotionEvent event) {
                if(event.getAction()==MotionEvent.ACTION_DOWN)
                {
                    b4.setValue("1");
                    try
                    {
                        Thread.sleep(3000);
                    }
                    catch(Exception e)
                    {
                    }
                }
                else if(event.getAction()==MotionEvent.ACTION_UP)
                {b4.setValue("0");
                }
                return false;
            }
        });
        bt18.setOnTouchListener(new View.OnTouchListener() {
            @Override
            public boolean onTouch(View v, MotionEvent event) {
                if(event.getAction()==MotionEvent.ACTION_DOWN)
                {
                    b5.setValue("1");
                    try
                    {
                        Thread.sleep(3000);
                    }
                    catch(Exception e)
                    {
                    }
                }
                else if(event.getAction()==MotionEvent.ACTION_UP)
                {
                    b5.setValue("0");
                }
                return false;
            }
        });
        bt19.setOnTouchListener(new View.OnTouchListener() {
            @Override
            public boolean onTouch(View v, MotionEvent event) {
                if(event.getAction()==MotionEvent.ACTION_DOWN)
                {
                    b6.setValue("1");
                    try
                    {
                        Thread.sleep(3000);
                    }
                    catch(Exception e)
                    {
                    }
                }
                else if(event.getAction()==MotionEvent.ACTION_UP)
                {
                    b6.setValue("0");
                }
                return false;
            }
        });
        bt20.setOnTouchListener(new View.OnTouchListener() {
            @Override
            public boolean onTouch(View v, MotionEvent event) {
                if(event.getAction()==MotionEvent.ACTION_DOWN)
                {
                    b7.setValue("1");
                    try
                    {
                        Thread.sleep(3000);
                    }
                    catch(Exception e)
                    {
                    }
                }
                else if(event.getAction()==MotionEvent.ACTION_UP)
                {

                    b7.setValue("0");
                }
                return false;
            }
        });
        bt21.setOnTouchListener(new View.OnTouchListener() {
            @Override
            public boolean onTouch(View v, MotionEvent event) {
                if(event.getAction()==MotionEvent.ACTION_DOWN)
                {
                    b8.setValue("1");
                    try
                    {
                        Thread.sleep(3000);
                    }
                    catch(Exception e)
                    {
                    }
                }
                else if(event.getAction()==MotionEvent.ACTION_UP)
                {
                    b8.setValue("0");
                }
                return false;
            }
        });
        bt22.setOnTouchListener(new View.OnTouchListener() {
            @Override
            public boolean onTouch(View v, MotionEvent event) {
                if(event.getAction()==MotionEvent.ACTION_DOWN)
                {
                    b9.setValue("1");
                    try
                    {
                        Thread.sleep(3000);
                    }
                    catch(Exception e)
                    {
                    }
                }
                else if(event.getAction()==MotionEvent.ACTION_UP)
                {
                    b9.setValue("0");
                }
                return false;
            }
        });
        bt23.setOnTouchListener(new View.OnTouchListener() {
            @Override
            public boolean onTouch(View v, MotionEvent event) {
                if(event.getAction()==MotionEvent.ACTION_DOWN)
                {
                    bsao.setValue("1");
                }
                else if(event.getAction()==MotionEvent.ACTION_UP)
                {

                    bsao.setValue("0");
                }
                return false;
            }
        });
        bt24.setOnTouchListener(new View.OnTouchListener() {
            @Override
            public boolean onTouch(View v, MotionEvent event) {
                if(event.getAction()==MotionEvent.ACTION_DOWN)
                {
                    bthang.setValue("1");
                }
                else if(event.getAction()==MotionEvent.ACTION_UP)
                {
                    bthang.setValue("0");
                }
                return false;
            }
        });
        sw2.setOnCheckedChangeListener(new CompoundButton.OnCheckedChangeListener()
        {
            @Override
            public void onCheckedChanged(CompoundButton buttonView, boolean b) {
                if(b)
                {
                    set.setValue("1");
                    Toast.makeText(MainActivity.this,"Đang học lệnh",Toast.LENGTH_LONG).show();
                }
                else {
                    set.setValue("0");
                }}
        });
        bthengio.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent manhinh=new Intent(MainActivity.this,hengio.class);
                MainActivity.this.startActivity(manhinh);
            }
        });
    }
    public void anhxa()
    {
        bthengio=(Button) findViewById(R.id.Buttontimers) ;
        sw2=(Switch) findViewById(R.id.switchs);
        bt1=(Button) findViewById(R.id.buttonon1);
        bt2=(Button) findViewById(R.id.buttonon2);
        bt3=(Button) findViewById(R.id.buttonon3);
        bt4=(Button) findViewById(R.id.buttonon4);
        bt5=(Button) findViewById(R.id.buttonup);
        bt6=(Button) findViewById(R.id.buttondw);
        bt7=(Button) findViewById(R.id.buttonnext);
        bt8=(Button) findViewById(R.id.buttonback);
        bt9=(Button) findViewById(R.id.buttonmenu);
        bt10=(Button) findViewById(R.id.buttonmute);
        bt11=(Button) findViewById(R.id.buttonexit);
        bt12=(Button) findViewById(R.id.buttonmode);
        bt13=(Button) findViewById(R.id.buttonp0);
        bt14=(Button) findViewById(R.id.buttonp1);
        bt15=(Button) findViewById(R.id.buttonp2);
        bt16=(Button) findViewById(R.id.buttonp3);
        bt17=(Button) findViewById(R.id.buttonp4);
        bt18=(Button) findViewById(R.id.buttonp5);
        bt19=(Button) findViewById(R.id.buttonp6);
        bt20=(Button) findViewById(R.id.buttonp7);
        bt21=(Button) findViewById(R.id.buttonp8);
        bt22=(Button) findViewById(R.id.buttonp9);
        bt23=(Button) findViewById(R.id.buttonpsao);
        bt24=(Button) findViewById(R.id.buttonpthang);
    }
}