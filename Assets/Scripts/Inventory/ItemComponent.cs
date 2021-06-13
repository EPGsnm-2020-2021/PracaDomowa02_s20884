using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemComponent : MonoBehaviour
{
    public int quantitynumber;
    public Animator animator;
    public GameObject Player;

    [Header("Setting")]
    public Item item;
    public KeyCode key;
    public ItemType type;

    [Header("UI Components")]
    public Image frame;
    public Image sprite;
    public Text quantity;
    public GameObject tooltip;
    public Text tooltipname;
    public Text tooltipdescription;

    [Header("Colors")]
    public Color highlightcolor;

    void Start()
    {
        if (item != null)
        {
            quantitynumber = item.defaultQuantity;
            type = item.type;
        }
        UpdateItem();
        Player = GameObject.Find("Player");
        animator = Player.GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(key))
        {
            Use();

        }




    }
    public void SetTooltip(bool active)
    {
        if (item == null)
        {
            tooltip.SetActive(false);
        }
        else
        {
            tooltip.SetActive(active);
        }
    }

    public void UpdateItem()
    {
        if (item == null)
        {
            sprite.sprite = null;
            sprite.color = new Color(1, 1, 1, 0);
            quantity.text = "";

        }
        else
        {
            sprite.sprite = item.sprite;
            sprite.color = new Color(1, 1, 1, 1);
            quantity.text = quantitynumber + "";
            tooltipname.text = item.itemName;
            tooltipdescription.text = item.description;
        }
    }
    public void Use()
    {
        if (item != null)
        {
            quantitynumber--;

            if (type == ItemType.HEAL)
            {
                GameObject player = GameObject.FindGameObjectWithTag("Player");
                PlayerHealth health = player.GetComponent<PlayerHealth>();
                health.Heal(1);
            }
            if(type == ItemType.WEAPON)
            {
                StartCoroutine(Attack());
            }

            if (quantitynumber <= 0)
            {
                item = null;
                SetTooltip(false);
            }
            UpdateItem();
            StartCoroutine(HighlightFrame());
        }
    }

    public IEnumerator HighlightFrame()
    {
        Color currentColor = frame.color;
        
        yield return new WaitForSeconds(0.1f);
        frame.color = currentColor;
    }

    public void SetItem(Item itemToSet)
    {
        if(item == itemToSet)
        {
            quantitynumber += itemToSet.defaultQuantity;
        } else
        {
            item = itemToSet;
            quantitynumber = itemToSet.defaultQuantity;
        }
        UpdateItem();

    }
    public IEnumerator Attack()
    {
        animator.SetBool("Attack", true);
        yield return new WaitForSeconds(1);
        animator.SetBool("Attack", false);
    }
}
public enum ItemType
{
    NONE,
    HEAL,
    WEAPON
}
