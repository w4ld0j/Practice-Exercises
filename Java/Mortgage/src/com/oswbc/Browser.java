package com.oswbc;

public class Browser {
    public void navigate(String adrres) {
        String ip = findIpAdress(adrres);
        String html = sendHttpRequest(ip);
        System.out.println(html);
    }

    private String sendHttpRequest(String ip) {
        return "<html></html>";
    }

    private String findIpAdress(String adrres) {
        return "127.0.0.1";
    }

}
