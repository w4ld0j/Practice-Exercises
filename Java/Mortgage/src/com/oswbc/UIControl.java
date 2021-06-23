package com.oswbc;

public class UIControl {
    private boolean isEnable = true;

    public UIControl(boolean isEnable) {
        this.isEnable = isEnable;
        System.out.println("UIControl");
    }

    public void enable(){
        isEnable = true;
    }
    public void disable(){
        isEnable = false;
    }
    public boolean getIsEnabled() {
        return isEnable;
    }
}
