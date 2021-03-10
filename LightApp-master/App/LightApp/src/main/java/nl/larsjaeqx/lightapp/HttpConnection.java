package nl.larsjaeqx.lightapp;

import android.app.Activity;
import android.os.AsyncTask;
import android.util.Log;

import org.apache.http.HttpResponse;
import org.apache.http.NameValuePair;
import org.apache.http.client.ClientProtocolException;
import org.apache.http.client.HttpClient;
import org.apache.http.client.entity.UrlEncodedFormEntity;
import org.apache.http.client.methods.HttpGet;
import org.apache.http.client.methods.HttpPost;
import org.apache.http.impl.client.DefaultHttpClient;
import org.apache.http.message.BasicNameValuePair;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.URL;
import java.util.ArrayList;
import java.util.List;

/**
 * Created by Lars on 1-2-14.
 */
public class HttpConnection  extends AsyncTask<String, Integer, String> {
    @Override
    protected void onPreExecute() {
        super.onPreExecute();
    }

    @Override
    protected String doInBackground(String... params) {

        Log.d("AsyncTask ", "started...");

        if(params[0].equals("update")) {
            setLight(params[1], params[2]);
        }

        Log.d("AsyncTask ", "done!");

        return "All Done!";
    }

    @Override
    protected void onProgressUpdate(Integer... values) {
        super.onProgressUpdate(values);
    }

    @Override
    protected void onPostExecute(String result) {
        super.onPostExecute(result);
    }

    private void setLight(String light, String status) {
        // Create a new HttpClient and Post Header
        HttpClient httpclient = new DefaultHttpClient();
        HttpGet httpget = new HttpGet("http://192.168.0.177/" + light + status);

        try {
            // Execute HTTP Post Request
            HttpResponse response = httpclient.execute(httpget);

        } catch (ClientProtocolException e) {
            Log.e("HttpConnection", "" + e.getMessage());
        } catch (IOException e) {
            Log.e("HttpConnection", "" + e.getMessage());
        }
    }
}