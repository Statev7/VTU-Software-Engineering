package com.example.eshop;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import java.util.ArrayList;

public class MainActivity extends AppCompatActivity {

    private ArrayList<User> users;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        this.users = new ArrayList<>();
        this.users.add(new User("user1", "user1"));
        this.users.add(new User("user2", "user2"));

        Button buttonId = this.findViewById(R.id.LogInBtn);
        EditText userName = (EditText)this.findViewById(R.id.UserNameField);
        EditText userPassword = (EditText)this.findViewById(R.id.UserPasswordField);

        buttonId.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

                String userNameAsString = userName.getText().toString();
                String userPasswordAsString = userPassword.getText().toString();

                for (int index = 0; index < users.size(); index++) {

                    String curruntUserName = users.get(index).getUserName();
                    String curruntUserPassowrd = users.get(index).getPassword();

                    boolean isUserValid = userNameAsString.equals(curruntUserName) &&
                            userPasswordAsString.equals(curruntUserPassowrd);

                    if (isUserValid){

                        Intent intent = new Intent(MainActivity.this, LoggedIn.class);
                        intent.putExtra("userName", userNameAsString);
                        startActivity(intent);
                        break;
                    }
                }
            }
        });
    }
}