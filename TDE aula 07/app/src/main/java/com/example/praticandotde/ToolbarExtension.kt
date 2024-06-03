package com.example.praticandotde

import android.icu.text.CaseMap.Title
import android.widget.Button
import androidx.appcompat.app.AppCompatActivity


fun AppCompatActivity.configureToolbar(title: String, enableBackButton: Boolean) {
        supportActionBar?.apply {
        this.title = "Home"
        setDisplayHomeAsUpEnabled(true)
    }
}
