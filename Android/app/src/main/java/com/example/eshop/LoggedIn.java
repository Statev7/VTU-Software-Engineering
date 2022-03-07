package com.example.eshop;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

public class LoggedIn extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_logged_in);

        String userName = getIntent().getExtras().getString("userName");
        String outPutMessage = "Hello" + " " + userName;

        TextView helloField = (TextView) this.findViewById(R.id.HelloField);
        helloField.setText(outPutMessage);


        //Toast.makeText(this, outPutMessage, Toast.LENGTH_SHORT).show();
    }
}