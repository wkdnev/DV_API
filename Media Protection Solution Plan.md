### MP-1 — Policy and Procedures (Control)

This requirement is about making sure the organisation has clear, written rules for protecting any physical or digital storage media, and that everyone who needs to follow those rules knows what to do. Without an up-to-date policy and practical, step-by-step instructions, important information could be handled incorrectly, lost, or exposed, which could lead to financial loss, legal problems, and damage to trust.

The organisation must create an organisation-wide media protection policy and supporting procedures. These documents must explain the purpose, what they cover, who is responsible, senior leadership’s commitment, how different parts of the business work together, and how compliance will be checked. They must also be aligned with relevant laws and the organisation’s standards.

The Chief Information Security Officer must be responsible for producing, maintaining, and sharing these documents. The policy must be reviewed and updated at least every year, and after significant events. The procedures must be reviewed and updated at least every year, and after significant events, including audit findings, security incidents, or changes to key legal or regulatory requirements.

The policy must be shared with Security and Privacy leadership, Information System Owners, and Media Custodians. The procedures must be shared with all staff who handle media, including Media Custodians and Information Technology Operations staff.

##### CISO-owned media protection policy & procedures lifecycle with evidence

- Category: Manual
- Priority: Critical

###### WHAT
Create and maintain an **organisation-level media protection policy** and **media protection procedures** that explain how media protection requirements are put into practice across the whole organisation.

###### WHY (control requirement)
MP-1 requires the organisation to establish and keep up to date **media protection policy and procedures** that cover the MP family controls implemented in systems and organisations. The guidance also requires that **security and privacy programmes work together**, that the policy/procedures are **reviewed and updated at least every year and after events that trigger review**, and that **simply repeating the controls is not enough**.

###### HOW (specific steps/approach)
1. **Appoint ownership and governance**: Name the **Chief Information Security Officer (CISO)** as the official responsible for managing the media protection policy and procedures.
2. **Define who receives the documents**:
   - Share the **policy** with **Security and Privacy leadership, Information System Owners, and Media Custodians**.
   - Share the **procedures** with **all staff who can access media**, including **Media Custodians and IT Operations staff**.
3. **Create organisation-level documents**:
   - Publish one organisation-level **Media Protection Policy** (or a small set of coordinated policies if organisational complexity requires it) covering purpose, scope, roles and responsibilities, management commitment, and coordination between security and privacy programmes.
   - Publish **Media Protection Procedures** that explain **how** the policy is followed in practice (step-by-step media handling by role), and that point to the MP family controls used by the organisation.
4. **Ensure legal and regulatory alignment**: Include a clear mapping of what applies and a review checklist, so the policy/procedures stay consistent with relevant laws, executive directives, regulations, and organisational standards.
5. **Use a controlled trigger model for reviews and updates**:
   - Review/update the **policy** **every year** and **after any event that triggers review**.
   - Review/update the **procedures** **every year** and **after any event that triggers review**, and specifically after **audit findings, security incidents/breaches, or changes in ITAR, EAR, HIPAA, GDPR, CMMC, or NIS2 requirements**.
   - For each trigger, record the decision (update needed / no update) and the reason.
6. **Keep audit-ready proof that documents are shared and current**:
   - Use controlled document management (version numbers, effective dates, approval records).
   - Keep proof of sharing (for example, the policy hub publication time and targeted notifications; procedures access/acknowledgement for media-access roles).

###### WHO
- **Chief Information Security Officer (CISO)**: owner of the policy/procedures; ensures governance, approvals, and document sharing.
- **Security programme lead** and **Privacy programme lead**: work together on content and what applies.
- **Information System Owners** and **Media Custodians**: provide operational input and confirm what applies.
- **IT Operations**: ensures the procedures are practical for media-access roles.

###### Acceptance criteria
- An **organisation-level** Media Protection Policy exists, is approved by the CISO, and is shared with the defined policy audiences.
- Media Protection Procedures exist, are approved under the same governance, and are shared with all defined media-access roles.
- Both documents have **documented review/update cycles**: **every year** and **after triggering events**; procedures also update after audit findings/incidents/breaches and the specified regulatory changes.
- Evidence exists for: version control, approvals/ownership, sharing to each required role group, and recorded trigger-based review decisions.

###### Actions Required for Compliance

- [ ] Appoint the Chief Information Security Officer (CISO) as the named person responsible for managing the media protection policy and its procedures.
- [ ] Draft and get approval for an organisation-wide media protection policy. Include its purpose, what it covers, who is responsible for what, and how security and privacy teams will coordinate.
- [ ] Draft and get approval for role-based media protection procedures that explain how the policy is put into practice (not just a repeat of the media protection controls).
- [ ] Define and document the distribution lists for:

- **Policy**: Security and Privacy leadership, Information System Owners, and Media Custodians  
- **Procedures**: All staff who can access media, including Media Custodians and IT Operations staff
- [ ] Set up a controlled document process that includes version numbers, start dates (effective dates), and records of who approved each document.
- [ ] Set review and update triggers, and record the results: review the policy every year and whenever a trigger event occurs; review the procedures every year and whenever a trigger event occurs, and also after audit findings, incidents, or breaches, and after any specified regulatory changes.
- [ ] Publish the policy and procedures on the organisation hub, and keep proof for audit purposes that they were shared and that the documents are up to date.


---

### MP-2 — Media Access (Control)

This requirement is about making sure only the right people can handle sensitive information stored on physical items, such as flash drives, external hard drives, magnetic tapes, CD/DVDs, and also paper records and microfilm. Without this, confidential or secret information could be accidentally or deliberately taken, copied, or viewed by unauthorised staff, visitors, or contractors, which could cause serious harm such as privacy breaches, regulatory problems, and damage to trust.

To meet this expectation, the organisation must clearly define and document who is allowed to access digital sensitive media (the system development team, authorised system administrators, and the information system owner) and who is allowed to access paper or microfilm sensitive records (authorised healthcare providers and the medical records custodian). It must put these rules into written policies and step-by-step procedures, ensure secure storage facilities are in place, restrict physical access to those storage areas, and keep records showing who accessed or received the media and when, so the organisation can demonstrate that the rules are followed in practice.

##### Controlled custody for in-scope media with role-based release

- Category: Manual
- Priority: Critical

###### WHAT
Set up a controlled custody model for **system media** (digital and non-digital) that contains **Confidential or Secret information**. Ensure access is limited to the organisation-defined roles for each type of media.

###### WHY (control requirement)
MP-2 requires: **“Restrict access to {{ mp-2_prm_1 }} to {{ mp-2_prm_2 }}.”**  
This means only the **system development team and authorised system administrators** may access **digital and non-digital system media containing Confidential or Secret information** (as defined by the provided parameters). The organisation must enforce this restriction for the specified media types.

###### HOW (specific steps/approach)
1. **Define and publish media access rules** in a single “System Media Protection / Media Access” procedure. This procedure must clearly map:
   - **Digital media types** in scope (e.g., flash drives, external/removable hard disk drives, magnetic tapes, optical media) to the **authorised roles**.
   - **Non-digital media types** in scope (e.g., paper records and microfilm containing patient/classified information) to the **authorised roles**.
2. **Create a media register and unique identifiers** for every item in scope (serial/label + classification + storage location + owning system/environment).
3. **Control physical custody for digital media** by storing items in locked vaults/controlled rooms. Release items only through a **sign-out process** that records:
   - the requester’s identity and role,
   - the media identifier,
   - the reason/business justification,
   - the date/time of release and return,
   - the approver/authoriser (where required by your internal process).
4. **Control custody for non-digital media** by limiting access to records/microfilm libraries to the authorised roles using badge/key control and **request/return logging** linked to the media register.
5. **Check identity as part of the release process** (for example, workflow approval linked to the organisation’s identity system, and badge verification at handover) so access is granted only to people in the defined roles.
6. **Keep audit evidence** (media register plus sign-out/return logs) for the organisation’s required retention period and make it available for audit.

###### WHO
- **Information Security / Security Governance Lead**: owns the media access procedure and approves the authorised roles.
- **IT/OT Infrastructure Manager (or equivalent)**: sets up vaults, storage locations, and custody processes.
- **System Owner / Information System Owner**: ensures the authorised roles list is correct and kept up to date.
- **Media Custodian(s) / Records Custodian**: runs the sign-out/request/return processes and maintains the media register.

###### Acceptance criteria
- Every in-scope digital and non-digital media item has a unique identifier and is recorded in the media register.
- Access to in-scope media is granted only through the controlled workflow to users whose role matches the organisation-defined authorised roles.
- Sign-out/request/return logs record the requester’s identity, role, media identifier, timestamps, and approver/authoriser (if applicable).
- Physical storage areas for media are access-controlled (locked/badge/key) and access is limited to the authorised roles.
- Audit checks confirm that no media was released to unauthorised roles and that the evidence can be retrieved for review.

###### Actions Required for Compliance

- [ ] Publish a media access procedure that clearly limits access to in-scope Confidential and Secret media to the defined authorised roles.
- [ ] Create and keep a media register that records, for every in-scope item, a unique identifier, its classification, and where it is stored.
- [ ] Set up locked vaults or controlled rooms for digital media, and allow access only to authorised roles.
- [ ] Set up a sign-out process for digital media that records: who requested it (identity and role), the media item identifier, the reason for the request, the relevant dates and times, and who approved or authorised it.
- [ ] Set up logging for requests and returns, and store non-digital media (paper and microfilm) in a secure, access-controlled system limited to authorised roles.
- [ ] Keep records of media access (the register plus sign-out, request, and return logs) for audit purposes, and carry out regular checks to confirm the records are complete and accurate.


---

### MP-3 — Media Marking (Control)

This requirement ensures that all sensitive information is clearly labelled, whether it is stored on a USB drive, hard drive, tape, disc, or paper. The labels must make it clear who the information may be shared with and how it must be handled. Without clear labelling, confidential material could be accidentally given to the wrong people, handled incorrectly, or left unsecured, which increases the risk of unauthorised access, loss, or inappropriate disclosure.

The organisation must have clear written rules and step-by-step procedures for applying these labels and handling instructions. It must also keep an up-to-date list of the exact labels it uses and assign responsibility to the correct staff members.

Labelling is not required for media that remains within the organisation’s approved secure areas and is never taken outside them. This applies only while the media stays within those access-controlled, escorted areas, such as accredited data centre rooms, secure server rooms, and controlled laboratories.

##### Enforce media marking with controlled-area exemption via workflow

- Category: Software
- Priority: Critical

###### WHAT
Set up a standard way to mark all system media (digital and non-digital). The markings must show the required plain-language security information (distribution limits and handling warnings). An exemption from marking is allowed only if the media stays inside the accredited, organisation-defined secure area and is not taken out of controlled locations.

###### WHY (control requirement)
MP-3 requires security markings for both digital and non-digital media using plain-language security information. The markings must reflect relevant laws, executive orders, directives, policies, regulations, standards, and guidance. The guidance also allows an exemption from marking only when the system media remains in controlled areas (as defined by the organisation) and is not removed from those controlled areas.

###### HOW (specific approach)
1. **Create a controlled media marking catalogue** that covers distribution limits and handling warnings for each type of information the application produces or uses. Define the exact label wording and format for each media type (for example: removable solid-state drive (SSD)/universal serial bus (USB), tape, optical media, and paper/microfilm containers).
2. **Define the organisation’s controlled areas** in the workflow configuration (for example: accredited on-premises data centre rooms, secure server rooms, and controlled laboratory areas). Include the access control and escort requirements that must be met for the exemption to be valid.
3. **Implement a media lifecycle workflow** linked to the organisation’s authoritative asset inventory (information technology asset management (ITAM)/configuration management database (CMDB)). Marking must be applied when media is created or received, and updated when the media moves. The workflow must:
   - Require label/marking information to be generated when media is linked to non-public information.
   - Allow an **“unmarked”** status **only** when the inventory location is within the configured controlled areas and movement records confirm the media has not been removed from controlled areas.
4. **Use standard label templates and a print/attach method** (for example, barcode/quick response (QR) code optional) so staff apply consistent markings. The workflow must require a **“marking confirmation”** step (scan and record) before media can be released for movement.
5. **Add operational enforcement and audit proof**: create audit records that show (a) which label template was used, (b) the distribution/handling attributes applied, (c) the controlled-area location at the time of any exemption, and (d) the movement history. Trigger alerts when inventory shows the media is outside controlled areas but the marking information/label confirmation is missing.
6. **Extend the approach to non-digital media** by requiring controlled stickers/labels on the immediate container/case or document sleeve. Link the container identifier to the records management system so the same “controlled area only” exemption logic can be audited.

###### WHO
- **Information Security (policy owner)**: approves the marking attribute catalogue, label formats, and controlled-area definitions.
- **ITAM/CMDB owner / Asset Management**: maintains the authoritative media inventory and the location/movement records.
- **Application/Platform Engineering**: integrates the application’s media lifecycle events with the marking workflow and evidence generation.
- **Facilities/Operational Technology (OT) Security (for physical escort/access)**: ensures controlled-area access and escort requirements are actually enforced. The workflow must not be the only control used to validate any exemption.

###### Acceptance criteria
- For every system media item associated with non-public information, the workflow produces and records the required plain-language security information (distribution limits and handling warnings) and the label confirmation evidence.
- The workflow allows **“unmarked”** status only when the item’s inventory location is within the configured controlled areas and movement history shows it has not been removed.
- Audit evidence exists for each media item: label template/version, applied attributes, marking confirmation, controlled-area location at the time of exemption, and movement history.
- Alerts/audit reports are produced for any media item recorded outside controlled areas that lacks marking evidence.
- Non-digital media containers/sleeves carry controlled labels and are traceable to the same inventory/records identifiers used for the exemption logic.

###### Actions Required for Compliance

- [ ] Define and publish the organisation’s list of controlled areas (including access control and escort requirements) that is used to check whether the MP-3 exemption applies.
- [ ] Create a catalogue of media marking attributes that is version-controlled, and that sets out distribution limits and handling cautions by information type and by media type.
- [ ] Set up a media lifecycle process linked to IT asset management (ITAM) and the configuration management database (CMDB) so that labels are generated and confirmed when media is received or created, and again whenever it is moved.
- [ ] Set up the process so an exemption (unmarked item) is allowed only when the inventory location is in controlled areas and the movement records show that nothing was removed.
- [ ] Use approved label templates (with optional barcode or quick response (QR) code) and require confirmation based on scanning and recording before any media is checked out.
- [ ] Create audit evidence and alerts for any media recorded outside controlled areas where there is no marking evidence.


---

### MP-4 — Media Storage (Control)

This requirement is about keeping all removable storage items and paper records physically secure, so sensitive information cannot be lost, stolen, or accessed by the wrong people. Without it, USB sticks, removable drives, SD cards, magnetic tapes, optical discs, and paper or microfilm could be left unsecured, removed without detection, or handled incorrectly, which could expose confidential or secret information.

The organisation must keep every type of removable digital media and every paper or microfilm record under physical control in controlled, badge-access areas. Entry and exit must be recorded, and inventories must be used to track what is stored and who is allowed to take items out and return them.

Secret-labelled digital media must be stored in the CML vault with badge-controlled access, monitored by closed-circuit television (CCTV), and tracked with item-by-item inventories. Access must be carried out by two authorised people.

Confidential-labelled paper and microfilm must be kept in locked storage within the CML document room, also with badge-controlled access and inventory tracking.

All system media must be protected until it is destroyed or made safe for reuse using approved equipment, methods, and procedures.

##### Implement CML for controlled media with logged access and dual-control

- Category: Manual
- Priority: Critical

###### WHAT
Set up and run a Controlled Media Library (CML) that physically controls every defined type of system media (removable digital media and non-digital paper/microfilm) within designated controlled areas. Use badge-controlled, logged entry and exit, inventory-based tracking, and stronger vault or locked-storage controls for media labelled **Secret** and **Confidential**.

###### WHY (control requirement)
MP-4 requires that system media (digital and non-digital) be physically controlled and securely stored in controlled areas. It also requires procedures for accountability, including inventories and controlled issue and return processes where applicable. Storage must match the security category or classification on the media—for example, stronger physical controls for higher classifications.

###### HOW (specific steps/approach)
1. **Define which media types are physically controlled** in the CML register, matching the organisation’s defined types:
   - **Digital:** removable solid-state drives (SSDs) and hard disk drives (HDDs), universal serial bus (USB) flash drives, secure digital (SD) cards, magnetic tapes, optical media.
   - **Non-digital:** paper records and microfilm.
2. **Use the organisation-defined controlled areas**:
   - **CML vault** for **Secret-labelled digital media**: badge-controlled access, monitored by closed-circuit television (CCTV), and managed through inventory records.
   - **CML document room** for **Confidential-labelled non-digital media**: badge-controlled access, locked storage, and managed through inventory records.
3. **Use an inventory-led accountability approach**:
   - Give each media item a unique identifier (for example, a barcode or quick response (QR) label). Record: media type, classification label, current location (vault/cabinet/awaiting destruction), status (in storage/issued/being transported), and assigned custodian.
   - Keep an audit-ready history of movements and any discrepancies.
4. **Control issue and return (where media is provided for use)**:
   - Require an authorised requestor role and a CML custodian to approve the issue.
   - Record each issue and return against the specific item identifier, including time, identity, and reason.
5. **Use physical controls that match the classification**:
   - **Secret-labelled digital media:** require **dual control** for vault access (two authorised people present/authorised) and ensure access is limited to the CML vault area.
   - **Confidential-labelled non-digital media:** store only in locked cabinets in the document room, with access limited to authorised personnel.
6. **Prepare evidence for audits**:
   - Keep badge entry and exit logs, CCTV access events (for the vault as configured), and inventory transaction logs for the organisation’s required retention period.
   - Carry out periodic inventory checks (for example, monthly or quarterly based on risk) and investigate any mismatches.

###### WHO (role responsible)
- **CML Custodian / Facilities Security Officer:** runs the CML, maintains the inventory register, and handles issue and return.
- **Information Security Officer (ISO):** approves how classifications map to storage locations and the dual-control requirements for Secret media.
- **Authorised Requestors / System Owners:** request media for issue and ensure it is returned promptly.
- **Internal Audit / Compliance:** checks the evidence (inventory, access logs, and reconciliation results).

###### Acceptance criteria
- All defined digital and non-digital media types are included in the CML inventory, each with a unique item identifier and classification label.
- **Secret-labelled digital media** is stored only in the CML vault, with badge-controlled access, CCTV monitoring, inventory management, and dual control for access.
- **Confidential-labelled non-digital media** is stored only in locked cabinets in the CML document room, with badge-controlled access and inventory management.
- Every media movement (issue/return) updates the inventory record and can be traced to an authorised identity and timestamp.
- Periodic inventory reconciliation is completed and documented; any discrepancies have documented investigation and corrective action.

###### Actions Required for Compliance

- [ ] Document the organisation’s approved list of physical and non-physical media types that are covered by the configuration management list (CML) scope.
- [ ] Set up the CML vault and the CML document room as the only approved secure locations for Secret-labelled digital information and for Confidential-labelled non-digital media, respectively.
- [ ] Create and run an inventory register that records every media item with a unique item ID, a category label, and its current location and status.
- [ ] Put in place a documented process for checking items out and back in. The process must record the item ID, the person’s identity, the date and time, and the reason for the change, and it must update the inventory records.
- [ ] Require two people to approve access to the Secret-labelled digital media vault, and allow entry only for authorised roles.
- [ ] Carry out regular checks to reconcile the inventory against the official register, and record how any differences were investigated and fixed.


---

#### MP-4.2 — Automated Restricted Access (Enhancement)

This requirement is about keeping close, door-by-door control over who can physically reach places where important media is stored. Access is controlled using keypad and card readers at the external entrances. Without this, unauthorised people could try doors until they find a way in, or enter and then tamper with or steal stored information—causing serious financial and operational harm.

To meet this expectation, the organisation must set up the keypads and card readers so that entry is allowed only for people who are listed as authorised in the access list linked to those devices. The access system must automatically record every attempt to enter the media storage areas made through the keypads or card readers, and it must also automatically record every successful entry.

These records must be kept as part of the organisation’s access and audit information, so access behaviour can be reviewed when needed.

##### PACS keypad/card readers with per-door ACLs and automated access logs

- Category: Software
- Priority: Critical

###### WHAT
Set up the physical access control system for every external entry to each media storage area so that:
1) entry is limited to authorised people using the organisation’s automated access methods (keypads and card readers), and this is enforced using access control lists (ACLs) for each entry; and
2) the system automatically records both access attempts and successful access events.

###### WHY (control requirement)
MP-4(2) enhancement requires limiting access to media storage areas and recording both **access attempts** and **successful access** using the organisation’s automated access methods (parameter: mp-4.2_prm_1). The guidance specifies automated methods such as keypads and card readers at external entry points, and the requirement explicitly asks for automated logging of both attempts and successful entry.

###### HOW (specific steps/approach)
1. **Map enforcement points**: Create an inventory showing, for each media storage area, its external entry points, and the specific keypad/card reader devices and door controllers that enforce access.
2. **Set per-entry ACLs**: Configure the access control system so that each reader/door grants entry only to identities listed in the relevant ACL (for example, badge/card IDs and/or keypad user IDs), aligned to the organisation’s authorised access list for that media storage area.
3. **Turn on automated event logging**: Enable event generation for both:
   - **access attempts** (denied/failed and/or attempted entries) based on keypad/card reader activity; and
   - **successful access** (successful entries) based on keypad/card reader activity.
   Make sure each log record includes at least: identity/credential, reader/door location, date and time, and outcome (granted/denied).
4. **Send and protect logs centrally**: Send access control events to the organisation’s central logging and security monitoring platform (security information and event management (SIEM)) using the access control system’s supported export method (agent, syslog, or application programming interface (API)). Apply log retention and integrity protections in line with organisational logging standards (for example, restricted administrator access to log storage and tamper-evident or write-once/immutable retention where available).
5. **Check end-to-end**: Carry out controlled tests for each media storage area:
   - try entry using an unauthorised credential and confirm an **access attempt** event is logged;
   - try entry using an authorised credential and confirm a **successful access** event is logged;
   - confirm events reach the central log store with the correct door/reader mapping and date/time.
6. **Control changes operationally**: Use the organisation’s change management process to control ACL updates and reader/door configuration changes (for example, require approval and keep configuration baselines). This ensures only authorised changes can alter who can access media storage areas.

###### WHO
- **Physical Security Lead / Physical Access Control System (PACS) Administrator**: device and door mapping, ACL configuration, and enabling event logging.
- **Security Operations (SOC) / SIEM Engineer**: log forwarding setup, retention and integrity settings, and validation in the central logging platform.
- **Information Security / Compliance**: evidence requirements, acceptance test criteria, and support for audits.

###### Acceptance criteria
- For every external entry to a media storage area, the keypad/card reader enforces an ACL that allows entry only to authorised identities.
- For every access attempt and every successful entry through those devices, the access control system produces matching automated log events.
- The central log store contains both attempt and granted events with the correct reader/door identifiers, identity/credential, date and time, and outcome.
- Test evidence (screenshots/exported events) shows that unauthorised attempts are logged and authorised entries are logged as granted for each mapped media storage area.

###### Actions Required for Compliance

- [ ] Take an inventory of every media storage location, and record which external access point connects to which specific keypad or card reader device and door controller.
- [ ] Set up access rules for each reader and each door so that only authorised identities can access each media storage area entry.
- [ ] Set up automatic logging for both access attempts and successful access (access granted) events on the access control system.
- [ ] Check that the log records include: the person’s identity or credentials, the reader or door location, the date and time, and the access outcome (granted or denied).
- [ ] Send access control events to the central security information and event management (SIEM) and apply the required record retention and access restrictions
- [ ] Carry out authorised and unauthorised access tests for each media storage area, and keep records of all logged attempts and any access that was granted.
- [ ] Place access control list (ACL) changes and reader/door configuration changes under formal change control, using approved configuration baselines.


---

### MP-5 — Media Transport (Control)

This expectation is about protecting sensitive information stored on removable devices or paper while it is being taken outside secure premises. The goal is to prevent it being lost, accessed by the wrong people, or changed without being noticed. Without these safeguards, a misplaced USB drive, external hard drive, tape, CD or DVD, or a sheet of confidential paper or microfilm could be stolen or altered during transit. This could lead to data breaches, fraud, and regulatory or reputational damage.

The organisation must clearly define what counts as “system media” and which locations are treated as controlled areas. It must then ensure that, when media leaves those areas, it is protected during transit: digital media must be encrypted using approved encryption, with the encryption keys managed by the system owner; non-digital media must be kept in locked, access-controlled containers.

All media must be transported in locked, tamper-evident packaging, with chain-of-custody records. The organisation must be able to account for the media throughout the journey, document each stage of release, handover, and actual movement, and limit all transport handling to named, authorised personnel only.

##### Encrypted removable media release with chain-of-custody tracking

- Category: Software
- Priority: Critical

###### WHAT
Set up an end-to-end process for moving system media **out of controlled areas** that can be fully checked later (audited). Any **digital removable media** must be **encrypted for transport** and protected using **system-owner key management**. Any **non-digital media** must be protected using **locked, access-controlled containers**. All media must be transported in **locked, tamper-evident containers/seals**, with **chain-of-custody** records and documented transport activities.

###### WHY (control requirement)
MP-5 requires that media moved outside controlled areas includes protections such as **encryption (cryptography)** and **locked containers**. It must also support **accountability** by limiting transport to authorised people and recording transport actions. It must include **documentation** for when media is released, when it enters the transport process, and for the actual transport.

###### HOW (specific steps/approach)
1. **Define scope and controlled areas** in the organisation’s media transport standard: list the system media types covered (for example, removable solid-state drives/hard drives, universal serial bus drives, tapes, compact discs/digital versatile discs; paper/microfilm) and specify which locations are “controlled areas” versus “outside controlled areas”.
2. **Encrypt digital media before release**: require that any covered digital media is encrypted before it leaves controlled areas using an **approved encryption method validated to FIPS 140-2**. Ensure encryption keys are managed by the **system owner** (or a named key custodian role acting under the system owner’s responsibility) using an enterprise key management service (hardware security module (HSM)/key management service (KMS)-backed), with role-based access and audit logs.
3. **Place media into locked, tamper-evident containers at physical release**: after encryption (for digital) or packing (for non-digital), put the media into **locked, tamper-evident containers**. Record the container ID and the tamper-evident seal ID in the chain-of-custody record.
4. **Use chain-of-custody and record transport events**: create a workflow record that, at minimum, captures: (a) release from the controlled area, (b) entry into the transport process, (c) every handover/transfer event (including handover to a courier), and (d) confirmation of receipt/return. Ensure the custody identifiers match the physical container/seal IDs.
5. **Limit handling during transport to authorised personnel**: connect the workflow to the organisation’s identity system so only users in an **authorised media transport** role/group can perform release, handover, and receipt actions. External couriers may be used for physical custody only, but they must not access encryption tools or key material.
6. **Keep documentation ready for audit**: keep the transport workflow records and supporting evidence (proof encryption was completed, seal/container IDs, handover scans/signatures) for the retention period defined by the organisation.

###### WHO
- **System Owner / Data Owner**: responsible for key management and approval of the encryption method.
- **Security/Compliance Lead**: owns the media transport standard (scope, controlled areas, documentation requirements).
- **IT Security Engineering / Identity and Access Management (IAM) Team**: implements identity-based authorisation and integrates the workflow with the identity provider (IdP).
- **Operations/Asset Management Team**: packs, seals, and performs custody handovers using the workflow.
- **Courier/External Transport Personnel (where applicable)**: perform physical handover/receipt only, under the custody record in the workflow.

###### Acceptance criteria
- For any covered **digital** media leaving controlled areas, there is evidence that encryption was completed using an **approved FIPS 140-2 validated mechanism**, and that keys are managed under the **system owner**.
- For any covered **non-digital** media leaving controlled areas, there is evidence that it was placed in **locked, access-controlled containers**.
- Every transport outside controlled areas has a complete **chain-of-custody** record with matching container/seal IDs, and documented release, entry into the transport process, and handover/receipt events.
- Only users in the authorised role can perform release/handover/receipt actions in the workflow; all such actions are logged.
- Audit checks (for example, the last 30/90 days) show that 100% of selected transports have complete, consistent documentation and no missing custody steps.

###### Actions Required for Compliance

- [ ] Publish a media transport standard that sets out which system media types are covered, and explains what counts as a controlled area versus an area outside the controlled boundary.
- [ ] Choose and register the approved Federal Information Processing Standards (FIPS) 140-2 validated encryption method for removable digital media, and keep a record of the validation evidence.
- [ ] Set up system-owner key management for removable media encryption using an enterprise key management service backed by a hardware security module (HSM), with audit logging and role-based access control (RBAC).
- [ ] Set up an identity-checked media release process that only allows release after either (digital) the encryption is finished or (non-digital) the item has been packed into a locked container.
- [ ] Create chain-of-custody records that document the release, entry into the transport process, every handover event, and the confirmation of receipt or return, including the container and seal identification numbers.
- [ ] Use tamper-evident locked containers and ensure that only authorised staff can carry out release, handover, and receipt actions within the workflow.


---

#### MP-5.3 — Custodians (Enhancement)

This requirement is about making sure there is one clearly named person who is responsible for carrying or handing over company storage items (such as drives, tapes, or other system media) when they leave secure premises. Without this, the wrong person could take responsibility, accountability could become unclear, and sensitive information could be mishandled, lost, or accessed by unauthorised people during transit.

To meet this expectation, the organisation must formally name a specific individual as the custodian for any transport of system media outside controlled areas. The organisation must record that person’s name in its media transport procedures (and any related plans and records). It must also ensure that the same named custodian carries out the transport every time.

If responsibility needs to change, the handover must be clear and documented before the next transport outside controlled areas. The transport records for each event must show the custodian’s name.

##### Named custodian sign-out/in for out-of-area media transport

- Category: Manual
- Priority: Critical

###### WHAT
Set up a process and supporting system workflow to ensure a **named, identified custodian** is **responsible for system media during every transport outside controlled areas**. The process must include **clear custodian handover** and **transport records** showing who had custody.

###### WHY (control requirement)
NIST MP-5(3) enhancement requires: **“Employ an identified custodian during transport of system media outside of controlled areas.”** The guidance also states that custody can only be transferred when an **unambiguous custodian is identified**.

###### HOW (specific steps/approach)
1. **Create and maintain a custodian roster** listing **specific people** (not job titles) who are authorised to act as custodians for out-of-area media transport.
2. **Define “controlled areas”** for the application’s operating environment (for example, secure server rooms, controlled operational technology (OT) zones, or designated secure handover desks). Treat any movement outside these boundaries as **out-of-area**.
3. **Require event-based dispatch and return records** for every out-of-area media movement. Each event record must capture:
   - media identifier (asset tag/serial),
   - departure and destination locations,
   - purpose,
   - **custodian full name** (chosen from the roster),
   - departure time and return/arrival time,
   - custody acknowledgement (electronic signature or equivalent).
4. **Enforce custodian handover**: if custody changes, the record must show an explicit **outgoing-to-incoming custodian transfer** before the media leaves the custody point for the next part of the journey.
5. **Ensure the person who signs is the person who physically carries/handovers** by requiring sign-out and sign-in at the custody point (or using an offline-capable workflow where systems are constrained).
6. **Keep audit-ready evidence**: store dispatch and return records in an append-only or tamper-evident way, and ensure they can be retrieved by media identifier and date/time for audit.

###### WHO
- **Information Security / Compliance Lead**: owns the control design and audit evidence requirements.
- **IT Operations / Service Desk Manager (or OT Maintenance Supervisor where applicable)**: owns the custodian roster and the dispatch/return workflow.
- **Custodians (named individuals)**: complete sign-out/sign-in and handover acknowledgements.
- **System/Workflow Owner (governance, risk and compliance (GRC)/IT service management (ITSM)/application owner)**: implements the workflow and record retention.

###### Acceptance criteria
- For every out-of-area media transport event in the last audit period, the transport record shows a **named custodian** who **signed** for custody.
- No out-of-area transport event can be completed without selecting a custodian from the roster and recording a custody acknowledgement.
- Where custody changes, the record includes an explicit outgoing-to-incoming custodian transfer **before** the next out-of-area leg.
- Records are retained and can be produced for audit by media identifier and time window.

###### Actions Required for Compliance

- [ ] Define and document the limits of the “controlled areas” where the application is allowed to operate.
- [ ] Create a list (roster) of named, authorised people (custodians) responsible for transporting system media outside the local area.
- [ ] Update the media transport procedures so that every move outside the usual area includes an event-based record showing when it was sent and when it was returned.
- [ ] Make custodian selection mandatory and require custody acknowledgement (an electronic signature or an equivalent method) as part of the dispatch and return process.
- [ ] Add an explicit handover step from the outgoing custodian to the incoming custodian, which must be completed before the next out-of-area journey leg.
- [ ] Set up tamper-evident, write-once retention for transport records, and confirm you can retrieve audit records using the media ID and the date and time.
- [ ] Train all custodians and relevant operations staff on the mandatory sign-out/sign-in and handover rules, and record when training is completed.


---

### MP-6 — Media Sanitization (Control)

This requirement ensures that when your organisation no longer needs a device, memory card, printer, scanner, or any other equipment, the information stored on it is made permanently unreadable before it is thrown away, given to someone else, or used again. Without this, sensitive information could be recovered by unauthorised people—for example from old computers, mobile phones, network equipment, or even paper records that still contain protected details—leading to privacy breaches, fraud, or regulatory issues.

To meet this expectation, the organisation must securely clear (sanitise) all relevant digital and non-digital storage, including storage built into devices and connected equipment, using approved methods that match the sensitivity of the information. Any media that cannot be reliably cleared must be destroyed.

For disposal of Secret material, the organisation should use the strongest feasible option first. If that is not appropriate, it should use the next suitable method, destroy when required, and keep evidence of what was done.

For release from organisational control, it must clear the media to the approved standard. If it cannot be proven that clearing was successful, it must destroy the media, and it must record the method used and the outcome.

For reuse, it must clear the media again, remove personal details where applicable, and verify that the process is complete, using supplier or specialist checks when needed.

##### Auditable media sanitisation workflow with NIST 800-88 methods

- Category: Manual
- Priority: Critical

###### WHAT
Set up an organisation-wide, auditable process to ensure that **all digital and non-digital system media** (including storage built into devices, removable storage in devices, network equipment, and peripherals) is **cleaned (sanitised) or destroyed** before **disposal**, **leaving organisational control**, or **being reused**.

###### WHY (control requirement)
MP-6 requires that sanitisation **removes information so it cannot be retrieved or rebuilt**, using **approved sanitisation methods** (for example: clear, purge, cryptographic erase, de-identification, destruction). The method must match the type of media and how sensitive the information is. The organisation must also choose and apply the correct method, including **destroying the media when other methods cannot be relied on**.

###### HOW (specific steps/approach)
1. **Define scope and when sanitisation is needed**: Keep an up-to-date, authoritative list of in-scope media types (digital and non-digital; built-in and removable storage; scanners/copiers/printers/multi-function devices; network components; mobile devices; paper/microfilm where applicable). Define the life-cycle events that require sanitisation: **disposal**, **release from organisational control**, and **reuse**.
2. **Choose the sanitisation method based on sensitivity and practicality**: For each sanitisation event, choose the method using the organisation’s approved techniques and procedures aligned to **National Institute of Standards and Technology (NIST) Special Publication (SP) 800-88 Revision 1** and related guidance:
   - For disposal of **Secret**: use **cryptographic erase where feasible**; otherwise use **purge or clear**; **destroy when required**.
   - For release from organisational control: sanitise to **NIST 800-88**; **destroy if sanitisation cannot be verified**.
   - For reuse: use **clear, purge, or cryptographic erase** per **NIST 800-88**; apply **de-identification where applicable**; **confirm completion**.
   - For media that cannot be reliably sanitised: **destroy**.
3. **Carry out sanitisation with checks and keep evidence**: For each item, record at least: asset identifier/serial number, media type and where it is stored (built-in/removable), the chosen technique, settings used (for example: whether the cryptographic erase key was available / the purge or clear method), date/time completed, who carried out and who authorised, and the **verification result**. If verification cannot be completed, send the item for **destruction** and record why.
4. **Use controlled handling and separation**: Create controlled “states” for items: “to be sanitised”, “sanitised—verification pending”, and “sanitised—released for disposal/reuse/release”. Use chain-of-custody for physical media and tamper-evident handling for digital media.
5. **Link to enterprise asset and device management tools**: Start sanitisation “playbooks” as part of the asset or device life-cycle (for example, decommissioning). Ensure cryptographic erase is carried out when encryption is enabled and keys are available; otherwise use purge/clear or destruction based on the approved decision rules.
6. **Treat non-digital media appropriately**: For paper/microfilm or documents that need sanitisation, use destruction or redaction methods that are equally effective as removal, and record what was used.
7. **Keep audit-ready records**: Keep sanitisation logs/evidence for the retention period defined by the organisation. Logs must include the method and outcome, and support audits and incident investigations.

###### WHO
- **Information Security / Compliance Lead**: owns the MP-6 sanitisation policy, the method-selection rules, and the audit evidence requirements.
- **IT Operations / Endpoint and Infrastructure Team**: carries out sanitisation playbooks and verification steps for endpoints, servers, and storage.
- **Asset Management / Configuration Management**: maintains the authoritative inventory and the life-cycle triggers.
- **Facilities / Records Management (for non-digital media)**: carries out destruction/redaction and provides evidence.
- **Authorised Security Officer / Approver**: authorises release from organisational control and any exceptions (for example, destruction when sanitisation cannot be verified).

###### Acceptance criteria
- 100% of in-scope media items that are **disposed**, **released**, or **reused** have a recorded sanitisation method and outcome.
- For disposal of **Secret**, **cryptographic erase is used where feasible**; otherwise purge/clear is used; **destruction is used when required**.
- For release from organisational control, sanitisation is completed to **NIST 800-88**, and any items with **unverifiable** sanitisation are **destroyed**.
- For reuse, items are sanitised using approved methods and **confirmation of completion** is recorded.
- Sanitisation of non-digital media uses **destruction or an equivalent-effect redaction/removal**, with evidence kept.
- Chain-of-custody and tamper-evident handling are demonstrated for physical media, and sanitisation evidence is retained for audit.

###### Actions Required for Compliance

- [ ] Define and publish the MP-6 sanitisation scope for all types of system storage media—digital and non-digital—including built-in (embedded) and removable storage.
- [ ] Create sanitisation decision rules that match each data sensitivity level and lifecycle event (disposal, release, reuse) to the approved National Institute of Standards and Technology (NIST) Special Publication 800-88 techniques and the required destruction criteria.
- [ ] Set up a documented chain of custody and a controlled process with defined stages for receiving, cleaning, checking, and releasing items.
- [ ] Standardise how sanitisation evidence is recorded (asset identifier, media type/location, method and settings, verification outcome, operator and approver, and dates/times) and enforce how long it is kept.
- [ ] Include data-sanitisation checklists in endpoint and infrastructure decommissioning. Use cryptographic erasure where possible, and use backup sanitisation methods when encryption keys are not available.
- [ ] Set a requirement to verify sanitisation and handle exceptions: if sanitisation cannot be verified, send the item for destruction and record the reason.
- [ ] Document and carry out the secure disposal of non-digital media (by destroying it or using an equivalent method to remove usable information), and keep audit records that can be checked.


---

#### MP-6.1 — Review, Approve, Track, Document, and Verify (Enhancement)

This requirement ensures that when the organisation wipes or destroys old storage media, it does so properly, with clear oversight and evidence. Without this, sensitive information could be left on devices that are thrown away, or media could be disposed of too early or in the wrong way—creating legal, financial, and reputational risk.

The organisation must:
- Define which types of media and disposal activities are covered.
- Use written procedures.
- Check each action against its records retention and disposal rules before it happens.

For every wiping and disposal event, the organisation must record:
- Who reviewed it and who approved it
- The type of media
- What data or files were on it
- The wiping method used
- The date and time
- Who carried it out
- What checks were performed and who performed them
- What disposal action was taken

It must also confirm that the wiping was effective before disposal, keep these records for the required period, and make them available for authorised review and audit.

##### Media sanitisation workflow with independent verification evidence

- Category: Software
- Priority: Critical

###### WHAT
Put in place an end-to-end, auditable process for disposing of media that **reviews, approves, tracks, records, and checks** every media sanitisation and disposal action. This includes **independent checking that sanitisation worked before disposal**.

###### WHY (control requirement)
The National Institute of Standards and Technology (NIST) Special Publication 800-53 **Media Sanitisation (MP-6(1))** enhancement requires the organisation to **review, approve, track, record, and check** media sanitisation and disposal actions. The guidance says the records must include: **who reviewed and approved**, **types of media**, **what files/data were stored on the media**, **which sanitisation method was used**, **date/time**, **who carried out the sanitisation**, **what checking was done and who did it**, and **what disposal action was taken**. It also requires the organisation to **confirm that sanitisation was effective before disposal**.

###### HOW (specific steps/approach)
###### Software (application/workflow feature)
1. **Create a “Media Sanitisation & Disposal” workflow** in the organisation’s enterprise governance, risk and compliance (GRC) / information technology service management (ITSM) system, with mandatory fields that directly match the MP-6(1) requirements:
   - Reviewer identity (who reviewed)
   - Approver identity (who approved)
   - Media type and asset/media identifier
   - Files/data description stored on the media (as recorded when the asset was taken out of service)
   - Sanitisation method(s) selected (from an approved list)
   - Sanitisation start/end date/time
   - Sanitiser identity (who performed the sanitisation)
   - Verification action(s) taken and verifier identity (who verified)
   - Verification evidence (tool logs/certificates/results)
   - Disposal action taken and date/time
2. **Enforce separation of duties and prevent skipping steps**:
   - Configure the workflow so **reviewer ≠ approver ≠ sanitiser ≠ verifier**.
   - Do not allow the process to move to “Disposal” unless a **verification status = effective** is recorded and verification evidence is attached.
3. **Link to the organisation’s official asset records and retention/disposal policy checks**:
   - Require an asset/media ID and pre-fill media details.
   - Add a policy check step that confirms the action is allowed under the retention/disposal rules (for example, legal hold/retention expiry) before sanitisation can proceed.
4. **Capture and keep audit evidence**:
   - Save sanitisation tool outputs (for example, erase or cryptographic erase reports) and verification outputs (for example, verification results/certificates) as attachments linked to the workflow record.
   - Protect workflow records with tamper-evident logging and keep them for the organisation’s required audit period.
5. **Require independent verification**:
   - Add a verification step where the verifier records what was checked and the result (effective/not effective), and attaches evidence.
   - If the result is “not effective”, send the case back for sanitisation (or require escalation) and block disposal.

###### Manual (governance/process alignment)
- Define and publish the **approved sanitisation methods** and the definition of **“verification effectiveness”** (what evidence counts as effective sanitisation for each media type), so the workflow’s verification step is consistent and meaningful.

###### WHO (role responsible)
- **GRC/ITSM workflow owner (Information Security/Governance)**: sets the workflow fields, evidence requirements, and verification effectiveness criteria.
- **Asset/IT operations (Asset Manager/CMDB owner)**: ensures asset IDs and media details are accurate.
- **Privileged operators (Sanitiser)**: performs sanitisation and uploads tool evidence.
- **Independent verifier (Information Security or a designated verification role)**: performs verification and records the outcome/evidence.
- **Approver (Data/Records owner or delegated authority)**: approves sanitisation/disposal in line with retention/disposal rules.

###### Acceptance criteria
- For **100%** of completed sanitisation/disposal workflow instances, the record includes **all MP-6(1) required elements**: reviewer, approver, media type, files/data description, sanitisation method, sanitisation date/time, sanitiser, verification action and verifier, and disposal action.
- The workflow **does not allow disposal** unless the verification outcome is recorded as **effective** and verification evidence is attached.
- Separation of duties is enforced so the reviewer/approver/sanitiser/verifier are **not the same person** (as set by the configured policy).
- Workflow records and attached evidence are kept and protected for audit purposes (tamper-evident logging/retention configured).

###### Actions Required for Compliance

- [ ] Define required workflow fields that exactly cover the MP-6(1) guidance elements: reviewer, approver, media type, files/data, sanitisation method, date/time, sanitiser, verification action/outcome and verifier, and disposal action.
- [ ] Set up the workflow so that different roles are not allowed to do each other’s work (the reviewer, approver, sanitiser, and verifier must be different people), and so that proof for verification is required, not optional.
- [ ] Integrate the workflow with the authoritative asset and configuration management database (CMDB) so that an asset or media identifier is required and the media details are filled in automatically.
- [ ] Add a step to check the retention and disposal rules before any sanitisation or disposal is carried out, and stop the process if the required retention or legal-hold conditions have not been met.
- [ ] Set up an independent check before disposal can begin, so disposal cannot start unless the verification result is recorded as effective and supporting evidence is attached.
- [ ] Set up tamper-evident audit logs and keep workflow records and evidence attachments for the full required audit period.
- [ ] Publish the approved sanitisation methods and the organisation’s definition of “verification effectiveness” for each media type, and link them to the workflow’s verification step.


---

#### MP-6.2 — Equipment Testing (Enhancement)

This expectation is about showing that the tools and step-by-step instructions your organisation uses to wipe or destroy old storage media are working properly—not just that staff are following them in theory. Without regular checks, there is a real risk that sensitive information could still be on devices after they are disposed of or reused. This could lead to data breaches, regulatory problems, financial loss, and reputational damage.

To meet this requirement, the organisation must test both its data-sanitisation equipment and its data-sanitisation procedures every quarter to confirm the intended result is achieved. Testing can be carried out internally or by a qualified and authorised external provider.

The organisation must keep clear records of the test results for both the equipment and the procedures as evidence for audits. This includes any results provided by external testers. These records must be stored and kept in line with the organisation’s records retention rules so they can be reviewed later.

##### Quarterly sanitisation equipment & procedure testing with audit evidence

- Category: Manual
- Priority: Critical

###### WHAT
Test sanitisation equipment and sanitisation steps at the organisation-defined frequency (mp-6.2_prm_1), and keep evidence showing that the sanitisation achieves the intended result.

###### WHY (control requirement)
NIST MP-6(2) enhancement requires: “Test sanitization equipment and procedures {{ insert: param, mp-6.2_prm_1 }} to ensure that the intended sanitization is being achieved.” This means both the *equipment* and the *procedure* must be tested on a defined schedule, with results that show the sanitisation outcome is achieved.

###### HOW (specific approach)
Run a repeatable quarterly testing programme that covers:
1) **Equipment testing**: operate each approved sanitisation device (for example, wipe stations, degaussers, shredders) using controlled test materials and the device’s intended settings.
2) **Procedure testing**: carry out each approved sanitisation procedure end-to-end using the exact current version of the procedure, including any required pre-checks and post-verification steps.
3) **Verification criteria**: set clear, measurable pass/fail rules for each sanitisation method (for example, pattern checks for wipe, verification for degauss, and output verification for destruction) and apply them consistently.
4) **Evidence capture**: record dated, attributable, and retrievable test results for both equipment and procedures. For procedure testing, link results to the exact procedure version.
5) **External testing (only if used)**: if an authorised external party performs testing, store their results as audit evidence with enough detail to show the quarter, method, and outcome.

Operationally, maintain:
- An authoritative **sanitisation equipment register** (device identifiers, supported media types, approved methods).
- An authoritative **sanitisation procedure library** with version control.
- A **quarterly test schedule** aligned to mp-6.2_prm_1 (default: quarterly).
- A controlled **evidence repository** (for example, a governance, risk and compliance (GRC) system/document management) with retention controls.

###### WHO
- **Data/Information Technology (IT) Security or Information Assurance Manager**: owns the testing programme and evidence requirements.
- **Sanitisation Operations Lead / Facilities or IT Asset Disposal Team**: carries out equipment and procedure tests.
- **GRC/Compliance Officer**: ensures evidence is complete, attributable, and retained.
- **External provider (if applicable)**: performs testing under authorisation and qualification requirements.

###### Acceptance criteria
- Evidence exists for the most recent quarter showing **equipment testing** was completed for every in-scope sanitisation device at the required frequency.
- Evidence exists for the most recent quarter showing **procedure testing** was completed for every in-scope sanitisation procedure at the required frequency, and each result is linked to the **exact procedure version**.
- Each test record includes: date/quarter, device/procedure identifiers, method/settings used, verification/measurement result, and pass/fail decision.
- Test evidence is **retrievable** and retained in line with organisational retention rules.
- If external testing is used, external results are available, attributable to the provider, and include enough detail to demonstrate the intended sanitisation outcome for that quarter.

###### Actions Required for Compliance

- [ ] Define and get approval for the quarterly testing scope for sanitisation equipment and procedures, aligned to **mp-6.2_prm_1**.
- [ ] Create clear, measurable pass-or-fail checks for every sanitisation method the organisation uses.
- [ ] Maintain a library of sanitisation procedures that are version-controlled, and keep an equipment register that uses unique device identifiers.
- [ ] Carry out quarterly equipment tests using approved test media, and record the device settings, the verification results, and whether each test passed or failed.
- [ ] Run end-to-end tests of the procedure every quarter using the exact current version of the procedure, and record the supporting evidence and whether each test passed or failed.
- [ ] Store all test results in a secure, controlled evidence repository that can be audited, with rules for how long the data is kept and how it can be retrieved.
- [ ] If you use an external tester, get authorisation and confirm they are qualified, then keep the external test reports showing the quarter, the testing method, and the results.


---

#### MP-6.3 — Nondestructive Techniques (Enhancement)

This expectation is about making sure any removable storage device—such as a USB stick or external hard drive—is checked and made safe before it is ever connected to your systems. The real-world risk is that a device used for the first time, or one whose past you cannot fully confirm, could already contain harmful software. If it is connected too soon, that software could spread through your organisation, disrupt operations, steal information, or cause other damage.

To meet this expectation, the organisation must clearly define and document when sanitisation (safe cleaning and checking) is required. This includes two situations:
- when devices are bought from manufacturers or suppliers before first use, and
- when a complete, positive chain of custody cannot be maintained.

The organisation must also ensure that sanitisation is non-destructive (the device is cleaned and checked in a way that does not physically destroy it), that devices are not connected until the process is finished, and that named staff are responsible.

Finally, it must keep records showing:
- which device was treated,
- when it was treated,
- how it was treated,
- who carried out the work, and
- evidence that the first connection to the system happened only after the sanitisation was completed.

##### Quarantine and sanitise-to-issue workflow for untrusted portable media

- Category: Manual
- Priority: Critical

###### WHAT
Put in place a controlled process that **cleans portable storage devices in a way that does not physically destroy them** before they are connected to any system, but only when the defined situations apply: **(1) devices bought from manufacturers or suppliers before first use, or (2) when a clear chain of custody cannot be proven**.

###### WHY (control requirement)
The National Institute of Standards and Technology (NIST) Special Publication 800-53 **Media Protection (MP-6(3))** enhancement requires: *“Apply nondestructive sanitization techniques to portable storage devices prior to connecting such devices to the system under the following circumstances: {{ insert: param, mp-06.03_odp }}.”* The guidance explains that portable devices can carry harmful software from sources that cannot be trusted, and that cleaning the device provides extra assurance beyond simply scanning it.

###### HOW (specific steps/approach)
1. **Set the trigger conditions** in a procedure linked to `mp-06.03_odp` (the situations):
   - Bought from manufacturers or suppliers before first use; **or**
   - A clear chain of custody cannot be proven.
2. **Create a quarantine + gate**:
   - Any device that meets the trigger is placed in a locked, access-controlled quarantine storage area.
   - Devices are labelled with a status that prevents them being issued (for example: *Quarantined / Sanitisation required / Sanitised & approved*).
3. **Carry out approved non-destructive cleaning based on the device type** (examples of approved techniques must be documented in the procedure):
   - Flash drives / Universal Serial Bus (USB) drives / external hard drives: run malware scanning (preferably offline where possible) and an approved logical wipe, format, or re-imaging method that does not physically destroy the device; then re-scan.
   - Optical media: check the integrity and contents, and re-authorise for use (or re-image/re-provision where the business process allows).
   - Magnetic or optical tapes: treat as untrusted; use the available checking or scanning tools and/or controlled re-provisioning in line with the organisation’s approved method list.
4. **Enforce “no connection until finished”**:
   - Only the sanitisation team can release devices from the controlled storage area.
   - Keep an auditable record showing that the **first connection to any system happens only after sanitisation approval**.
5. **Keep auditable records for each device**:
   - Unique identifier (serial number or asset tag), date received, supplier (if applicable), custody status, sanitisation method, start and end time, person who performed it, person who approved it, and any supporting evidence outputs (for example, scan report references and wipe/format confirmation).
6. **Add operational controls to reduce the risk of bypass**:
   - Configure endpoint management, mobile device management (MDM), and endpoint detection and response (EDR) policies to restrict Universal Serial Bus (USB) mass storage for non-administrative users where feasible, and require an exception process that routes devices through the sanitise-to-issue workflow.

###### WHO (role responsible)
- **IT Security / Cybersecurity**: owns the sanitisation procedure and the approved method list.
- **IT Operations / Service Desk**: receives devices, labels them, and manages quarantine handling.
- **Sanitisation team (IT/Infrastructure security technicians)**: performs non-destructive sanitisation and provides evidence.
- **System owner or delegated approver**: confirms sanitisation is complete before the device is issued.

###### Acceptance criteria
- For every portable storage device that meets the `mp-06.03_odp` situations, there is evidence that **non-destructive sanitisation was completed before the device is first connected to any system**.
- Devices are not released from quarantine without recorded sanitisation approval (device status labels and access to the controlled storage area are clearly enforced).
- Sanitisation records include: device identifier, method, timestamps, performer, approver, and supporting evidence artefacts.
- Endpoint management, mobile device management (MDM), and endpoint detection and response (EDR) controls (or an equivalent compensating control) clearly prevent or route unauthorised direct Universal Serial Bus (USB) connection attempts into the sanitise-to-issue workflow.

###### Actions Required for Compliance

- [ ] Document the MP-6(3) trigger conditions, as they are mapped to mp-06.03_odp, in the media sanitisation procedure.
- [ ] Set up a secured quarantine storage area and a device labelling system that prevents devices from being issued until sanitisation has been approved.
- [ ] Publish an approved list of non-destructive sanitisation methods, organised by media type, and require staff to use only the methods from that list.
- [ ] Create an information technology service management (ITSM) work-ticket template that requires: device identifier, method used, date and time stamps, person who carried out the work, person who approved it, and supporting evidence attachments.
- [ ] Use a controlled “clean before use” checkpoint so devices cannot be connected until sanitisation approval has been recorded.
- [ ] Set up endpoint management, mobile device management (MDM), and endpoint detection and response (EDR) controls for USB access (or use an equivalent compensating control) to prevent anyone from bypassing the “sanitise-to-issue” process.


---

#### MP-6.7 — Dual Authorization (Enhancement)

This expectation is about making sure that when valuable computer storage devices are securely wiped before they are disposed of, handed over, or put back into use, two properly trained and authorised people must independently approve and carry out the wiping.  

This matters because if one person can do it alone, there is a higher risk of mistakes, incomplete wiping, or even false claims that the work was completed—leaving sensitive information exposed.  

To meet this expectation, the organisation must clearly define which types of storage devices (such as solid-state drives, hard drives, removable drives, and storage arrays) require this two-person approach. It must then use documented procedures so that wiping cannot begin, and cannot be signed off, without two separate approvals and two separate people carrying out the work.  

The organisation must also keep clear records showing who approved the wiping, what was wiped, and evidence that the process was followed. Where feasible, it should rotate the pairings to reduce the chance that the same two people could collude.

##### Two-person workflow gate for dual-authorised system media sanitisation

- Category: Software
- Priority: Critical

###### WHAT
Set up a “two-person approval” process that stops the sanitisation of in-scope **system media** (for example: solid-state drives (SSDs), hard disk drives (HDDs), removable drives, and storage arrays) from being **started or finished** unless **two technically qualified, independently authorised people** both approve it, and **two different people** carry out and/or check the sanitisation. Keep complete, traceable records that can be audited.

###### WHY (control requirement)
MP-6(7) enhancement requires: **“Enforce dual authorization for the sanitization of {{ insert: param, mp-06.07_odp }}”**. The guidance also requires that sanitisation cannot happen unless **two technically qualified people** perform the required task. This dual approval helps prevent **mistakes** and **false claims** that sanitisation was completed.

###### HOW (specific steps/approach)
1. **Define the in-scope media** in the sanitisation workflow form/template for **mp-06.07_odp** (system media: SSDs, HDDs, removable drives, storage arrays). Require asset identifiers (serial number/asset tag) and the intended outcome (disposal or reuse).
2. **Enforce independent dual approval** in the workflow: require two different approver identities (Authoriser A and Authoriser B) with timestamps before the ticket can move to **“Ready to Execute”**. Add a technical check to ensure the same person cannot be used for both approval roles.
3. **Enforce two-person performance**: split the work into two required, identity-linked steps (for example: **“Performed by”** and **“Second performer/verification”**). The second person must be different from the first and must complete the required verification step (for example: tool output/log capture and verification evidence) before the ticket can move to **“Completed”**.
4. **Link evidence to the specific asset and method**: require attachments/fields for the sanitisation method, erase tool/job logs, verification results, and a completed checklist that matches the organisation’s sanitisation procedure for the chosen media type.
5. **Restrict who can approve and who can perform** using enterprise identity and access management (IAM) and role-based access control (RBAC), so only people listed as technically qualified in a **skills/competency matrix** can approve or carry out the work. (If staff rotation is practical, apply pairing rules to avoid repeating the same pair beyond a defined limit; otherwise, document why and list compensating controls.)
6. **Ensure auditability**: keep an unchangeable history of workflow status changes and links to evidence, so an auditor can trace: media asset → two approvals (two identities) → execution (two identities) → verification evidence → completion.

###### WHO
- **Security/Compliance Lead**: owns the dual-authorization policy/workflow requirements and what evidence must be kept.
- **IAM/Privileged Access Manager**: sets up role mappings and competency-based authorisation.
- **IT service management (ITSM)/Platform Owner (for example, ServiceNow/JSM administrator)**: builds the workflow states, approval gates, and evidence capture.
- **Sanitisation Operators (two-person team)**: carry out the sanitisation and provide the required verification evidence.

###### Acceptance criteria
- A sanitisation ticket for in-scope **system media** cannot reach **“Ready to Execute”** without two distinct, technically qualified approvers.
- A sanitisation ticket cannot reach **“Completed”** unless two distinct identities complete the execution/verification steps.
- The workflow prevents the same identity being used for both approver roles and for both performer roles.
- For every completed sanitisation event, the record includes: media asset identifiers, method, tool/job logs, verification evidence, and timestamps linked to both individuals.
- An audit review of a sample of completed tickets confirms end-to-end traceability from approvals to sanitisation evidence for the specific media asset.

###### Actions Required for Compliance

- [ ] Define which sanitisation media types are in scope for **mp-06.07_odp** in the workflow template, and require asset identifiers and disposal (disposition) fields.
- [ ] Set up the IT service management (ITSM) workflow so that “sanitisation” cannot move to “execution” unless there are two separate approvers, each identified distinctly, with the approval times recorded.
- [ ] Set up workflow checks to prevent the same user identity from being used for both independent approval roles.
- [ ] Split the process into two required identity-checked steps: the first step is done by the first person, and the second step is done by a second person (or verification). Do not allow the process to complete unless the two identities are different.
- [ ] Require and check supporting evidence and attachments for each asset, including erasure tool or job logs, verification results, and the relevant method-specific checklist.
- [ ] Limit who can approve or carry out actions by using identity and access management (IAM) role mappings, based on a maintained technical skills and competency matrix.
- [ ] Enable audit-ready retention of workflow status changes and evidence links for each completed sanitisation event


---

#### MP-6.8 — Remote Purging or Wiping of Information (Enhancement)

This requirement is about being able to delete company information from devices you no longer fully control, including when you need to do it remotely. If a laptop, mobile phone, or cloud-managed server is lost, suspected to be compromised, or an employee’s access is ended, there is a risk that sensitive data could be read or misused by unauthorised people.

To meet this expectation, the organisation must provide a remote wipe or purge function for end-user laptops, mobile devices, and cloud-managed servers. This should allow wiping to be triggered when device control is lost, compromise is suspected, or access is terminated.

Any remote wipe must only be allowed after strong identity checks, so unauthorised people cannot successfully request or approve a wipe.

The organisation must also keep clear records showing:
- who approved the wipe,
- when it was approved,
- which device or server was wiped,
- what action was taken, and
- whether it completed successfully.

##### Identity-gated remote wipe for managed endpoints and servers

- Category: Software
- Priority: Critical

###### WHAT
Set up a remote “purge/wipe” function for the organisation’s defined **systems or system parts** (for example, end-user laptops, mobile devices, and cloud-managed servers). This must be able to be started **remotely** when the defined **conditions** apply (for example, loss of device control, suspected compromise, or termination of access). Make sure wiping can only be carried out after **strong authentication**, and that it is protected against unauthorised attempts to start it.

###### WHY (control requirement)
The NIST MP-6(8) enhancement requires the organisation to **provide the ability to purge or wipe information** from the defined systems/system parts **remotely**. Guidance also states that remote purge/wipe actions must use **strong authentication** to reduce the risk that unauthorised people could purge or wipe the system/device. The wipe can be done by overwriting data, or by destroying the key needed to decrypt encrypted data.

###### HOW (specific steps/approach)
1. **Choose and standardise the wipe method for each platform:**
   - For laptops/mobile devices: use the organisation’s **mobile device management / unified endpoint management (MDM/UEM)** “wipe/purge” capability (use a full wipe for lost or compromised devices where appropriate; ensure it matches the organisation’s approach to encryption of data stored at rest).
   - For cloud-managed servers: set up remote purge/wipe using the cloud provider’s managed tools (for example, instance termination followed by secure re-provisioning, or destroying cryptographic keys for encrypted storage volumes). Ensure the result is irrecoverable data in line with your encryption design.
2. **Define the approved wipe process linked to the defined conditions:**
   - Create a process that links **loss of device control**, **suspected compromise**, and **termination of access** to a wipe request.
   - Require a human approval step before wiping happens (not just creating a ticket). Record the identity of the person who approved it.
3. **Use strong authentication for wipe approval and execution:**
   - Require phishing-resistant multi-factor authentication (MFA) / strong authentication for anyone who can approve or trigger wipe actions in the MDM/UEM console and any connected application programming interfaces (APIs).
   - Use additional “step-up” authentication specifically for the wipe action where supported, and limit access to wipe functions to a dedicated role.
4. **Stop unauthorised people from starting wipes:**
   - Use the principle of least privilege with role-based access control (RBAC), so only a small set of authorised roles can approve and carry out wipes.
   - Restrict or tightly control any automated/programmatic or API routes used to trigger wipes (for example, use dedicated service accounts with limited permissions, and ensure they cannot be used without the approval process).
5. **Ensure the action is auditable and traceable:**
   - Configure the management platform(s) to record: who approved it, the time, the device/server identifier, the wipe type (purge/wipe), the condition that triggered it, and whether it completed successfully.
   - Send these records to the security information and event management (SIEM) system and keep them according to the organisation’s logging retention requirements.
6. **Test and confirm end-to-end:**
   - Run controlled test wipes on representative enrolled devices and a non-production server workload to confirm the wipe completes and that unauthorised accounts cannot initiate or approve wipes.

###### WHO (role responsible)
- **Security Operations / Incident Response Lead:** owns the wipe process and the mapping of conditions.
- **Identity and Access Management (IAM) Lead:** enforces strong authentication and step-up rules for wipe approvals.
- **Endpoint Management Lead (MDM/UEM)** and **Cloud Infrastructure Lead:** implement the platform-specific wipe/purge capabilities and role-based access control (RBAC).
- **SIEM/Logging Engineer:** ensures audit records are exported, linked together where needed, and retained.

###### Acceptance criteria
- Remote wipe/purge can be started for the defined **systems/system parts** (laptops, mobile devices, and cloud-managed servers) when the defined **conditions** occur.
- Wipe execution requires **strong authentication** (phishing-resistant multi-factor authentication (MFA) / step-up) and is limited to an authorised set of roles.
- Attempts by unauthorised users (including through console/API access routes) cannot successfully trigger or approve a wipe.
- Audit records exist for every wipe showing: who approved it, approval time, target identifier, triggering condition, action taken, and success/failure outcome.
- End-to-end tests show successful wipe completion and correct audit logging.

###### Actions Required for Compliance

- [ ] Set up mobile device management (MDM), user environment management (UEM), and cloud tools so that devices and servers in the agreed endpoint and server categories can be remotely wiped or erased.
- [ ] Set up an approval process so that device wipe requests are raised only when one of the defined situations applies: loss of device control, suspected compromise, or termination of access.
- [ ] Require phishing-resistant strong authentication and additional identity checks (step-up authentication) before approving or carrying out a device wipe in the management console and in any connected application programming interfaces (APIs).
- [ ] Apply least-privilege role-based access control (RBAC) by creating a dedicated “wipe approver” role and limiting wipe permissions to that role only.
- [ ] For every wipe, enable and export audit logs to the security information and event management (SIEM) system. Each log must include the approver’s identity, the time and date, the target identifier, the condition, the type of action, and the result.
- [ ] Run controlled test wipes and negative tests to confirm that unauthorised accounts cannot start or approve wipes, and that wipe completion is verified.


---

### MP-7 — Media Use (Control)

This requirement is about preventing people from connecting their own memory sticks, external drives, or other removable storage to systems that contain Confidential or Secret information, unless the organisation has explicitly approved that device. If this is not controlled, a lost or unapproved device could be used to copy sensitive data, install harmful software, or make it difficult to identify who is responsible for any resulting problems.

To meet this expectation, the organisation must ban personally owned removable media on all systems and components that handle Confidential or Secret information, unless the device is registered and approved. The organisation must enforce this by blocking unauthorised removable-device connections and preventing both reading from and writing to any non-approved device.

The organisation must also prohibit any portable storage device that does not have an identifiable owner. Finally, the organisation should document the rules for using removable media, set clear expectations for user behaviour, record the technical settings used to enforce the restrictions, keep audit evidence showing enforcement actions, and assign clear responsibilities to the appropriate staff, including system and network administrators.

##### Enforce approved removable media only for Confidential/Secret systems

- Category: Software
- Priority: Critical

###### WHAT
Put in place both technical and non-technical controls to restrict or prevent the use of specific types of system media (especially personally owned portable storage such as unregistered flash drives and external hard drives) on systems and components that handle **Confidential or Secret** information. Ensure that only **approved** removable media can be used, and that portable storage devices with **no identifiable owner** are not allowed.

###### WHY (control requirement)
MP-7 requires restricting or prohibiting certain types of system media on specific systems and components. In this case, the organisation’s intent is to **prohibit** personally owned portable storage devices and **unregistered** removable media on **all organisational systems and system components handling Confidential or Secret information**. This will be enforced through **device registration**, **blocking of ports**, and **turning off read and write access** for removable media that is not approved.

###### HOW (specific approach)
###### 1) Set the media-use rules and scope (non-technical)
- Create an MP-7 media-use rule set that clearly lists which media types are prohibited (for example: personally owned portable storage devices; unregistered flash drives/external hard drives/removable media) and the condition for allowed use (registered and approved).
- Define which systems and components are covered: **all organisational systems and system components handling Confidential or Secret information**.
- Define the approval model: every approved device must be linked to an **identifiable owner** (a user or a service account). Include what it is approved for (which environments/systems it may be used on) and the approval end date/when it must be rechecked.

###### 2) Enforce when a device is connected (technical)
- Set up **port/connection blocking** for removable media on covered endpoints and servers (for example, block USB storage and/or block external storage device connections by default).
- Apply **device registration enforcement** so only devices listed in the approved registry can connect.
- If any non-approved removable media is detected, enforce **disabling read and write** (at minimum, write must be disabled). The organisation-defined requirement also requires disabling read and write for non-approved media.

###### 3) Deny devices with “no identifiable owner” (technical + process)
- Make registration mandatory for removable media use on covered systems.
- Configure the enforcement to **block by default** any removable device that cannot be matched to an approved record with an identifiable owner.

###### 4) Provide audit records and operational evidence
- Keep central records (logs) showing: device identifier, connection attempt, the enforcement outcome (blocked/disabled), and the enforcement policy/version used.
- Send enforcement events to the security information and event management (SIEM) system so repeated blocked attempts and attempts to use non-approved devices can be monitored and alerted on.

###### WHO
- **Information Security / Chief Information Security Officer (CISO) office**: owns the MP-7 policy and manages the approval process.
- **Endpoint/Server Platform Engineering**: implements and maintains the removable-media enforcement settings.
- **Service Desk / IT Operations**: runs the device registration process and maintains the approved media registry.
- **System Owners** (for Confidential/Secret systems): confirm the scope and approve exceptions only through the defined registration process.

###### Acceptance criteria
- On covered Confidential/Secret systems, **personally owned and unregistered removable media cannot be used** (connections are blocked and/or read/write is disabled).
- Only removable media listed in the approved registry with an **identifiable owner** can connect and work according to the approved scope.
- Enforcement logs are created for every connection attempt and kept according to the organisation’s logging and retention requirements, with events visible in the SIEM system.
- A documented registration/approval process exists, and at least one pilot device can be registered, approved, and used successfully, while an unregistered device is denied.

###### Actions Required for Compliance

- [ ] Define and publish MP-7 rules for media use, including which media types are not allowed and which media are allowed only when they are registered and approved for Confidential and Secret systems.
- [ ] Create an approved register for removable storage devices. It must record the device identifier, the identifiable owner, what the approval covers, and the approval expiry date (including when it must be rechecked and recertified).
- [ ] Set a default “deny” rule for removable media on covered devices and servers (block unauthorised connections from Universal Serial Bus (USB) drives and other external storage).
- [ ] Set up controls to block any removable storage media that is not approved, so that on the covered systems it cannot be used to read or write data.
- [ ] Send enforcement events to security information and event management (SIEM) and keep audit records that show the device identifier, the connection attempt, and the enforcement result.
- [ ] Run a pilot: register one approved device and confirm it works, while any unregistered or personal device is blocked and cannot read or write.


---

#### MP-7.2 — Prohibit Use of Sanitization-resistant Media (Enhancement)

This requirement is about preventing staff from using certain “hard-to-wipe” storage devices in company systems. These devices can still retain information even after they are meant to be cleared. If this is not controlled, sensitive business data could be recovered by someone who later obtains the device, creating a serious risk of data leaks, regulatory issues, and reputational damage.

To meet this expectation, the organisation must clearly define and document which types of media it treats as not reliably sanitised. This includes compact flash, embedded flash, solid-state drives, and USB removable media. The organisation must keep an up-to-date list so staff can recognise these devices.

The organisation must then put a clear ban on these devices in its rules for media use and in staff guidance. It must assign clear responsibility for following the rules, and ensure that system settings and enforcement controls prevent these media types from being used on relevant systems.

The organisation must also keep evidence of these restrictions in its policies, procedures, and system documentation. It must be able to show that staff understand what they must do, and that systems actually block the prohibited devices in practice.

##### Enforce ban on sanitisation-resistant media via media catalogue

- Category: Manual
- Priority: Critical

###### WHAT
Put in place an organisation-wide, auditable ban on using sanitisation-resistant storage media in organisational systems by (1) defining and maintaining one single, authoritative list of prohibited media types and (2) using that list to enforce the ban consistently across IT and work activities that sit close to operational technology (OT).

###### WHY (control requirement)
MP-7(2) (enhancement) requires the organisation to **prohibit the use of sanitisation-resistant media**. Sanitisation resistance includes **compact flash, embedded flash on boards/devices, solid state drives, and USB removable media**. The aim is to stop information being left behind when cleaning methods cannot reliably remove data without damaging the media.

###### HOW (specific steps/approach)
1. **Create and maintain a Media Catalogue (single source of truth)** that clearly marks the following as **Prohibited / Sanitisation-resistant**:
   - Compact Flash (CF)
   - Embedded flash on boards/devices
   - Solid State Drives (SSDs) (including common enterprise formats such as 2.5-inch, M.2, and NVMe where applicable)
   - USB removable media (USB mass storage)
2. **Add recognition guidance** to the catalogue so staff can reliably identify prohibited media (for example, device markings, typical physical forms, and examples of “embedded flash module” situations).
3. **Publish the ban as a firm rule** in the organisation’s media-use policy and supporting procedures (not “discourage”), referencing the catalogue categories and requiring that any work needing storage media uses only approved alternatives.
4. **Build the catalogue into day-to-day operational processes** for the in-scope enterprise application environment:
   - Update service request/ticket templates so requesters must choose the media type from the catalogue, and approvers must confirm it is **not** sanitisation-resistant.
   - Add clear technician/engineer work-order instructions for any OT-adjacent maintenance tasks (for example, engineering workstation activities and HMI/SCADA support) to prevent inserting/installing prohibited media.
5. **Assign named responsibilities** (for example, IT infrastructure owner, endpoint/security engineering lead, and OT maintenance lead where applicable) for owning the catalogue, updating it, and keeping enforcement evidence.
6. **Produce audit-ready evidence** by creating a version-controlled record of:
   - The current prohibited media catalogue
   - The policy/procedure wording that enforces the ban
   - Workflow documents (ticket/work-order templates) showing the catalogue is used
   - Change-control records for updates to the catalogue

###### WHO (role responsible)
- **Information Security Manager / Chief Information Security Officer (CISO) office**: owns the media-use policy/ban and catalogue governance.
- **IT Infrastructure and Endpoint Security Lead**: ensures the catalogue is referenced in IT workflows and documentation for the enterprise application environment.
- **OT/Industrial Systems Engineering Lead (if OT-adjacent activities exist)**: ensures technician work-order guidance prevents prohibited media use in relevant OT maintenance contexts.
- **Service Management Process Owner**: updates ticket/work-order templates and approval steps.

###### Acceptance criteria
- The organisation has a **version-controlled media catalogue** that explicitly lists **compact flash, embedded flash, SSDs, and USB removable media** as prohibited sanitisation-resistant media.
- The media-use policy/procedures state a **prohibition (hard ban)** on using these media types in organisational systems and reference the catalogue.
- Service request/ticket and work-order templates for in-scope systems **require selection/confirmation** against the catalogue (no “free text” bypass).
- Named roles are documented for catalogue ownership and enforcement in workflows.
- Audit evidence exists showing the catalogue and ban are actively referenced in operational workflows (policy text + templates + change-control records).

###### Actions Required for Compliance

- [ ] Define and publish a version-controlled media catalogue that lists compact flash, embedded flash, solid-state drives (SSDs), and USB removable media as prohibited because they are resistant to sanitisation (data wiping).
- [ ] Update the organisation’s media-use policy and procedures to strictly prohibit any prohibited media types, and refer to the Media Catalogue.
- [ ] Add recognition guidance (for example, how the format looks and marking examples) to the media catalogue to help staff identify items correctly.
- [ ] Update the service request and work-order templates so that media type selection and approval are controlled by the Media Catalogue.
- [ ] Assign named owners for catalogue governance and to provide evidence that workflow rules are enforced (information technology (IT) infrastructure or endpoint lead and operational technology (OT) maintenance lead where applicable).
- [ ] Create audit-ready evidence packs, including the latest versions of relevant policies and procedures, catalogue versions, screenshots or exports of the workflow templates, and records of change-control approvals.


---

### MP-8 — Media Downgrading (Control)

This requirement is about making sure that before we send data outside the organisation or reuse equipment, we first remove or securely wipe what remains on the storage. This prevents sensitive information from being recovered by the next user. Without this, confidential or secret information could be unintentionally exposed, rebuilt, or read from old drives, exported files, or other storage media. That could cause financial, legal, and reputational harm.

To meet this requirement, the organisation must use a documented, proven process to reduce and sanitise storage in a way that matches the sensitivity of the information being removed. The process must use the strongest suitable method (including making encrypted data unreadable where feasible) and must keep evidence showing the work was checked and completed.

The organisation must:
- identify every removable memory item, every solid-state drive (SSD) and hard disk drive (HDD), and every exported dataset leaving the organisation that contains Confidential or Secret information;
- check that the sanitisation level is suitable for the person or organisation receiving it;
- carry out the sanitisation using the process; and
- keep item-by-item records showing what was done, when, by whom, and that it was verified before anything is released.

##### Automated media downgrading workflow with crypto-erase and evidence

- Category: Software
- Priority: Critical

###### WHAT
Implement an end-to-end **media downgrading/sanitisation workflow** for any **removable media, SSD/HDD drives, and exported datasets leaving the organisation** that contain **Confidential or Secret** information. The workflow must choose a **downgrading method appropriate to the information’s classification**, carry out **cryptographic erasure where feasible**, ensure the result is suitable for the **intended recipient release level**, and produce **item-by-item verification evidence**.

###### WHY (control requirement)
MP-8 requires that media downgrading applies to **digital and non-digital media intended for release outside the organisation**, including **system media**. Downgrading must remove information so that it **cannot be retrieved or reconstructed**, including ensuring **unused (empty) space contains no information**, and must be supported by a **defined process**.

###### HOW (specific steps/approach)
1. **Define and put the downgrading process into practice by classification** (Confidential vs Secret) following the organisation’s process, including **cryptographic erasure where feasible** and **verification logging**.
2. **Standardise encryption for data stored at rest** on storage volumes and datasets so that **crypto-erase (making encryption keys unusable/securely destroying keys)** is possible when downgrading is required.
3. **Create an automated workflow** that runs whenever an asset/export is marked for external release:
   - Inputs: asset identifier/serial (for drives/media), dataset export identifier, data classification (Confidential/Secret), intended recipient, and required target release level.
   - Method selection: choose the required downgrading outcome and any allowed method(s) based on classification and whether encryption makes crypto-erase feasible.
   - Execution: carry out crypto-erase first where feasible; if crypto-erase is not applicable, use the stronger method defined in the downgrading process.
   - Verification: capture the tool output and verification results that show the downgrading outcome.
4. **Check recipient suitability before release**: confirm that the recipient’s authorisation/permissions allow the **target release level** that matches the downgrading outcome.
5. **Keep auditable, item-specific evidence for every downgraded item**: asset/export ID, classification, method used, crypto-erase/key action details (where applicable), verification results, operator, approver (if required), date and time, and a link to the external release/shipment/export record.

###### WHO
- **Information Security / Data Protection Lead**: owns the downgrading process definition and the mapping from classification to method.
- **Platform/Infrastructure Engineering (Storage/Database)**: implements encryption-at-rest standards and integrates sanitisation tools.
- **Application/Release Management Owner**: ensures exports are labelled with classification and sent through the workflow.
- **IAM/Access Management Owner**: checks recipient authorisation for the target release levels.
- **Security Operations / Compliance**: reviews evidence packs and monitors workflow exceptions.

###### Acceptance criteria
- For every external release of **Confidential/Secret** removable media, SSD/HDD drives, and exported datasets, the workflow produces **item-specific verification evidence** showing the downgrading method and verification outcome.
- Where encryption is in place, **cryptographic erasure** is carried out (key invalidation/secure key destruction) and recorded in the evidence pack.
- The workflow prevents external release if recipient authorisation does not match the **target release level**.
- Evidence packs are kept and can be retrieved by asset/export ID for audit within the organisation’s retention requirements.
- No external release happens for qualifying items unless a complete downgrading/verification record exists.

###### Actions Required for Compliance

- [ ] Define the rules for downgrading information from **Confidential** to **Secret**, including any **cryptographic erasure** where it is feasible, and the verification steps that must be completed to confirm it has been done correctly.
- [ ] Standardise encryption for data stored on storage volumes and datasets so that, for eligible media, the encryption keys can be deleted to make the data unreadable (crypto-erase).
- [ ] Set up an automated process that starts when qualifying assets or exports are released externally, and then chooses the correct downgrading method based on their classification.
- [ ] Add a check that confirms the recipient is authorised for the intended release level, and block the release if they are not.
- [ ] Where possible, carry out “crypto-erase” (invalidating the encryption key or securely destroying it). If this is not possible, use the defined stronger method instead.
- [ ] Capture and store item-specific proof of verification (the method used, the results, and the person who performed and approved it, with dates and times), and link it to the external release record.


---

#### MP-8.1 — Documentation of Process (Enhancement)

This requirement ensures that whenever the organisation lowers the protection level for stored devices or media, it keeps a clear record of what was changed. Without this, downgraded media could be handled incorrectly, used for the wrong purpose, or altered without proper permission—raising the risk that sensitive information ends up with the wrong people.

To meet this expectation, the organisation must record every action to downgrade media, including:
- the method used
- the unique identification number of the specific item downgraded
- the identity of the person who authorised and/or carried out the change

These records must be kept as part of the organisation’s media protection procedures and its system security documentation. The organisation must also maintain an up-to-date list of which media items need downgrading, so each action can be matched to the correct item.

The organisation should also ensure that relevant audit information is retained, and that the roles responsible for documenting, authorising, and carrying out downgrades are clearly defined.

##### Media Downgrade Register with method, media ID, and authorisation

- Category: Software
- Priority: High

###### WHAT
Implement a controlled, auditable **Media Downgrade Register** that records every action to downgrade system media, including:
- the **downgrade method/technique** used,
- the **unique identification number** of the downgraded media,
- the **identity of the person who authorised and/or carried out** the downgrade.

###### WHY (control requirement)
NIST MP-8(1) (Enhancement) requires the organisation to **record system media downgrade actions**. The guidance specifies recording the **downgrade method**, the **media identification number**, and the **identity of the authorised and/or performing person**.

###### HOW (specific steps/approach)
1. Create and maintain an authoritative **media inventory** (authoritative IDs/tags/serial numbers) and a status flag showing whether each item is **eligible/required for downgrading**.
2. Use a **single workflow-backed register** (for example, an IT service management (ITSM) / governance, risk and compliance (GRC) case workflow) as the only supported way to record downgrades.
3. Configure the workflow so required information must be completed before submission:
   - Downgrade method/technique (restricted to approved options)
   - Media unique identifier (checked against the media inventory)
   - Authoriser identity (required when authorisation is separate)
   - Performer identity (required)
   - Date/time(s) and environment/system reference (for example, live/test/disaster recovery (DR), application/system name)
   - Reason/trigger mapped to the organisation’s media protection procedure (for example, end of retention, reclassification)
4. Apply validation checks:
   - Do not allow submission if the media ID is not found in the inventory, or if it is not in an eligible state that **requires downgrading**.
   - Apply separation of duties where the organisation’s media protection procedure requires it (authoriser is not the same person as performer). If separation of duties is not required, record the same-person case explicitly in line with policy.
5. Store completed register entries as **controlled records** (document management/governance, risk and compliance (GRC) retention) and ensure they are linked from the relevant **media protection procedures** and system security documentation.
6. Keep the workflow system’s audit trail for evidence and make it searchable, so it is clear the record matches the downgrade action (for example, workflow event history, approvals, and completion logs).

###### WHO (role responsible)
- **Information Security / Data Protection Officer**: owns the register requirements, field definitions, and retention/access rules.
- **Media Custodian / IT Asset Manager**: maintains the authoritative media inventory and eligibility status.
- **System/Application Owner or Authorising Manager**: provides authorisation identity and approval.
- **Privileged Operator / Storage Administrator**: carries out the downgrade and provides performer identity.
- **GRC/ITSM Administrator**: sets up the workflow, validations, and controlled record retention.

###### Acceptance criteria
- For every completed media downgrade, there is a register entry containing: **downgrade method/technique**, **unique media identifier**, and **authoriser and/or performer identity**.
- Each register entry references a media ID that exists in the authoritative inventory and was in an eligible “requires downgrading” state at the time of submission.
- Register records are stored as controlled documentation with defined retention and access controls, and are linked to the organisation’s media protection procedures/system security documentation.
- Workflow audit trail evidence is retained for approvals and completion, and can be produced for audit within the organisation’s evidence timeframe.

###### Actions Required for Compliance

- [ ] Set out the required information fields for the Media Downgrade Register, including: method or technique, media identification, the identity of the person authorising the downgrade, the identity of the person carrying out the downgrade, the dates and times, and the system reference.
- [ ] Create or update the official media inventory, ensuring each item has a unique identifier and a flag that shows whether it is eligible for downgrading.
- [ ] Set up a workflow-supported register (IT service management (ITSM) / governance, risk and compliance (GRC)) to check that media IDs match the inventory, and to stop submissions for items that are not eligible.
- [ ] Where required, ensure different people perform different steps in the workflow (separation of duties), and make sure any cases where the same person would do multiple steps are handled according to the organisation’s media protection procedure.
- [ ] Set up rules to control how long register records and link entries are kept, and who can access them. Also link these records to the media protection procedures and the system security documentation.
- [ ] Check that the audit trail is kept for the required period, and provide a sample evidence pack that shows the full downgrade record from submission through approval and completion.


---

#### MP-8.2 — Equipment Testing (Enhancement)

This requirement is about making sure the tools and step-by-step instructions your organisation uses to reduce the security level of stored media actually work as intended, not just on paper. Without regular checks, media that has been downgraded could end up with a higher security level than expected (leading to delays and extra cost) or, worse, with the wrong level of protection (leaving sensitive information exposed).  

To meet this expectation, the organisation must test both the downgrading equipment and the downgrading procedures at least once every quarter. Each time, the organisation must confirm that the media is downgraded to the expected lower security state.  

The organisation must keep clear records showing what was tested, the result of each equipment and procedure test, and details of any downgrading activities carried out, so an auditor can verify that the quarterly testing matches what happens in practice.

##### Quarterly test harness for media downgrading equipment & procedures

- Category: Software
- Priority: High

###### WHAT
Set up a repeatable quarterly test process that (1) tests the organisation’s approved media downgrading equipment, (2) tests the organisation’s approved media downgrading procedures, and (3) confirms that downgrading achieves the intended lower security state.

###### WHY (control requirement)
The National Institute of Standards and Technology (NIST) Special Publication 800-53, Media Protection (MP)-8(2) enhancement requires: “Test downgrading equipment and procedures {{ insert: param, mp-8.2_prm_1 }} to ensure that downgrading actions are being achieved.” The organisation-defined frequency parameter **mp-8.2_prm_1** is set to **quarterly**, so both the equipment and the procedures must be tested at least once every quarter, with confirmation that the downgrading outcome is achieved.

###### HOW (specific steps/approach)
1. **Create and maintain a controlled test setup** in an isolated, access-controlled environment that uses the same approved downgrading equipment and the same versions of the procedures used in day-to-day operations.
2. **Keep registers** for:  
   (a) downgrading equipment (asset identifier, make/model, firmware/software versions) and  
   (b) downgrading procedures (procedure name, version, effective date).
3. **Use a standard quarterly test script** that follows the real downgrading workflow: prepare representative media, carry out the downgrading using the approved equipment, then verify the media is in the expected lower security state using an objective verification method (for example, tool output/state checks and/or cryptographic/state verification consistent with the downgrading method).
4. **Automatically capture audit-ready evidence** for each quarterly run: test date/time, equipment identifier/version, procedure version, media identifiers/types, verification results, and pass/fail outcome. Store evidence in a tamper-evident repository (for example, write-once, read-many (WORM) or other immutable retention, or signed reports) and keep records for audit traceability.
5. **Ensure the test matches real downgrading** by using the same identifiers (equipment identifier and procedure version) in both the quarterly test and the operational downgrading records; the quarterly test report must reference the procedure/equipment identifiers.
6. **Plan and control quarterly testing** through the organisation’s change and release governance process (calendar trigger plus approval gates) and limit execution and approvals to authorised roles.

###### WHO
- **Information Security / Data Protection Lead**: owns the quarterly testing requirement, the verification criteria, and evidence retention.
- **Infrastructure/Storage/IT Operations Lead**: runs the downgrading test setup and ensures the correct equipment/procedure versions are used.
- **Compliance/Audit Liaison**: checks that evidence meets audit traceability expectations.

###### Acceptance criteria
- At least **once every quarter**, the organisation can show that **downgrading equipment** was tested and that results confirm downgrading achieved the intended lower security state.
- At least **once every quarter**, the organisation can show that **downgrading procedures** were tested (using the approved procedure version) and that results confirm the intended downgrading outcome.
- For each quarterly test, there is an auditable record that includes: equipment identifier/version, procedure version, test date, representative media identifiers/types, verification method/results, and pass/fail outcome.
- Quarterly test evidence is stored with tamper-evident/immutable retention and can be traced to the identifiers used for operational downgrading activities.

###### Actions Required for Compliance

- [ ] Define and document the expected checks for verifying a lower security state before downgrading media.
- [ ] Set up a controlled quarterly test to reduce media quality, using only approved equipment and the approved versions of the test procedure.
- [ ] Create and keep up-to-date records of equipment and procedures, using unique identifiers and version numbers.
- [ ] Set up automated recording of evidence for every quarterly test run, including the equipment ID, the procedure version, the media identifiers, the verification results, and whether the test passed or failed.
- [ ] Schedule quarterly execution with role-based access control (RBAC) and approval checkpoints
- [ ] Store test evidence in an unchangeable, tamper-evident repository and keep it for the required period so it can be used for audit traceability.
- [ ] Update the operational downgrading process so it records the same equipment and procedure identifiers as those used in the quarterly tests.


---

#### MP-8.3 — Controlled Unclassified Information (Enhancement)

This requirement is about making sure that any storage device or other media holding sensitive information that is not meant for public release is properly “downgraded” before it leaves the organisation. Without this, confidential material could be accidentally published or given to the public, which could cause legal, financial, and reputational harm.

To meet this expectation, the organisation must first identify which media items contain Controlled Unclassified Information, then downgrade those items before any public release. This must be done using only approved methods and tools, following the organisation’s written and documented procedures. The organisation must also involve the correct responsible staff and information security reviewers as required, keep clear records of what was done (including which approved method was used, who carried it out, and when it was completed), and ensure the records are detailed enough to be checked later.

Finally, the organisation must document its approach in system-level planning so the process can be repeated and consistently followed.

##### Approved CUI media downgrading workflow with release gate

- Category: Software
- Priority: Critical

###### WHAT
Set up an end-to-end, auditable process that (1) identifies system storage media that contain Controlled Unclassified Information (CUI), (2) downgrades that media before any public release, and (3) uses only approved sanitisation tools, methods, and procedures, with proof collected for audit.

###### WHY (control requirement)
National Institute of Standards and Technology (NIST) Media Protection (MP)-8(3) (enhancement) requires that system media containing CUI is **downgraded before public release**, and that the downgrading uses **approved sanitisation tools, methods, and procedures**.

###### HOW (specific steps/approach)
1. **Create and maintain a CUI media register** in the application’s operational tools (for example, information technology service management (ITSM) / configuration management database (CMDB)). Record each media identifier (serial/asset tag), location, owner, environment (production/testing/disaster recovery), and a CUI flag.
2. **Define an approved sanitisation catalogue** (tool + method + limits by media type + required verification method + required evidence fields) and ensure the workflow allows only selections from this catalogue.
3. **Build the workflow with “hard gates”**: any “public release” action (export, shipment, handing over to an external party, publishing a public dataset, or any other release-to-public activity) must be blocked unless the workflow has a completed sanitisation record linked to the specific media identifier(s).
4. **Enforce authorisation and correct procedure use**: require role-based approval for (a) starting sanitisation and (b) security review sign-off. Require operators to carry out sanitisation only on approved stations/tools configured for the selected method.
5. **Automatically capture verification proof**: store tool outputs (for example, sanitisation reports), method identifiers, dates and times, operator identity, and verification results (for example, checksum/verification artefacts as required by the approved procedure) in an append-only or tamper-evident store.
6. **Integrate with monitoring**: raise alerts if any release-to-public event happens without a linked, completed sanitisation record for all media marked as CUI.

###### WHO (role responsible)
- **Application/Service Owner**: ensures the workflow is built into release/export/publication activities.
- **Information Security (CUI/MP-8 owner)**: maintains the approved sanitisation catalogue and approves the security review steps.
- **ITSM/Operations Lead**: maintains the media register and workflow configuration.
- **Privileged/Authorised Media Sanitisation Operators**: carry out sanitisation using approved tools/methods and provide the required verification outputs.

###### Acceptance criteria
- For every media item marked as CUI in the media register, **no release-to-public action can be completed** unless a linked sanitisation record exists showing: approved tool/method/procedure, operator identity, completion date and time, and verification evidence.
- The workflow allows sanitisation selections only from the approved catalogue.
- Audit proof can be retrieved by media identifier and is tamper-evident/append-only.
- Monitoring generates an alert (and blocks release where technically possible) when a release-to-public event occurs without completed downgrading evidence for CUI media.

###### Actions Required for Compliance

- [ ] Create and fill a controlled unclassified information (CUI) media register with unique media identifiers and a CUI status flag.
- [ ] Publish an approved sanitisation catalogue that includes: the tool, the method, any limits on the type of media, how the sanitisation will be verified, and the required evidence fields.
- [ ] Set up a workflow that prevents any release to the public unless a completed sanitisation record is linked to the specific media identifiers.
- [ ] Set up role-based access control (RBAC) so only authorised users can start sanitisation and approve the security review sign-off
- [ ] Integrate the sanitisation process with automatic recording of tool results, the operator’s identity, the date and time, and the verification evidence, and store all records in tamper-evident storage.
- [ ] Set up monitoring rules to alert (and, where possible, stop) any release to the public that does not have linked, completed downgrading evidence for controlled unclassified information (CUI) media.


---

#### MP-8.4 — Classified Information (Enhancement)

This requirement ensures that any storage device or removable media that contains sensitive, officially classified information is made safe before it leaves the organisation. If it is not, a disk, drive, tape, or memory card could be given to someone who is not allowed to see that information, which could result in unauthorised disclosure, regulatory breaches, and serious harm to people and operations.

To meet this requirement, the organisation must first identify which media contains classified information and check whether the intended recipient has the required permission. If they do not, the organisation must change the classified information to unclassified status before it is released, using only approved, documented methods and tools, and making sure that only information confirmed as unclassified is transferred.

The organisation must also keep clear, auditable records showing which media was processed, when it was processed, who carried out the work, what approved method was used, and the verified unclassified result. Finally, it must have up-to-date policies and procedures, named responsible staff, and training so the process is carried out consistently.

##### Authorisation-gated media release workflow with approved downgrading

- Category: Software
- Priority: Critical

###### WHAT
Set up an end-to-end, approval-controlled process for releasing system media that contains classified information. The process must: (1) identify the media and its classification status, (2) check whether the intended recipient has the required access approvals, (3) if they do not have approval, downgrade the classified information to unclassified using only approved sanitisation tools, methods, and procedures, (4) confirm that the result is unclassified, and (5) only then release or hand over the media—while keeping records that can be audited.

###### WHY (control requirement)
MP-8(4) requires that system media containing classified information is downgraded before it is released to people who do not have the required access approvals. Further guidance requires that downgrading uses approved sanitisation tools, methods, and procedures to transfer information that has been confirmed as unclassified from classified systems to unclassified media.

###### HOW (specific steps/approach)
1. **Create and maintain an official media register** in the application or infrastructure tools. It must record, at minimum: the media identifier (serial or asset ID), classification status/level, owning system, current location, and release history.
2. **Add a pre-release recipient approval check** integrated with the organisation’s identity and authorisation service (for example, role-based access control (RBAC) or attribute-based access control (ABAC) policy evaluation). The process must decide whether the intended recipient(s) have the required access approvals for the media’s classification level.
3. **Apply release “gating” in the process**: the “release/hand-over” action must be blocked unless either (a) the recipient is approved for the media’s classification level, or (b) the media has completed an approved downgrading process with a verified unclassified result.
4. **Control the approved downgrading**: when the recipient is not authorised, create a sanitisation work order that can only be approved and carried out by designated sanitisation roles. The work order must reference the **approved sanitisation tool(s)**, **approved method/procedure ID**, tool version, and the operator’s identity.
5. **Verify and confirm the unclassified result**: capture verification evidence produced by the approved sanitisation and verification method (for example, a tool report, verification scan output, or independent confirmation sign-off as defined in the approved procedure). The process must attach this evidence to the media release record.
6. **Keep auditable records**: store process records and evidence that link the media identifier to the recipient, the approval decision, the downgrading method, the verification evidence, and the release time and approver identity.

###### WHO (role responsible)
- **Application/Infrastructure Security Engineer**: responsible for the workflow design, approval logic, and integration with identity and authorisation.
- **Media/Sanitisation Custodian (authorised sanitisation role)**: carries out and/or approves sanitisation work orders using approved tools and procedures.
- **System Owner / Data Protection Officer (if applicable)**: checks that the approved sanitisation procedures and verification requirements match organisational standards.
- **Audit/Compliance Officer**: reviews how evidence is retained and how it supports auditability.

###### Acceptance criteria
- For any media marked as containing classified information, the workflow must prevent release to unauthorised recipients unless downgrading is completed and verification evidence is attached.
- Downgrading work orders must reference only approved sanitisation tool(s), approved method/procedure ID(s), and the operator identity and tool version.
- Verification evidence must be captured and linked to the specific media identifier and release event.
- Audit records must show: media identifier, classification status, intended recipient, approval check result, downgrading method, verification outcome, and release/hand-over timestamp.
- Any attempted release without completed verification evidence must be blocked and logged.

###### Actions Required for Compliance

- [ ] Create and publish an approved catalogue of sanitisation tools, techniques, and procedures, including unique procedure IDs and the required proof of verification.
- [ ] Set up an official media register that records each media identifier, its classification status, and its release history.
- [ ] Set up an authorisation-controlled media release process that prevents hand-over unless the recipient’s authorisation has been confirmed or the downgrading has been completed.
- [ ] Integrate the workflow with the organisation’s identity and access authorisation service to check whether recipients are authorised to access the media at the required classification level.
- [ ] Set up sanitisation work orders so only authorised roles can carry out and approve the approved downgrading methods, and so the tool version and operator identity are recorded.
- [ ] Capture verification evidence and attach it to the media release record, so that only confirmed unclassified results are allowed to be released.
- [ ] For every media release event, enable audit logging and keep the supporting evidence. Record: media ID, recipient, authorisation decision, the method used to downgrade, the verification result, the approver, and the date and time (timestamp).

