### PE-1 — Policy and Procedures (Control)

This requirement is about making sure the organisation clearly sets out how it will protect its physical sites and the surrounding environment, and keeps those rules up to date. Without an agreed, documented approach, responsibilities can be unclear, updates may be missed after incidents or changes, and the organisation may not meet legal and regulatory expectations—leaving people, assets, and operations more exposed to theft, sabotage, or unauthorised access.

The organisation must create and document an organisation-wide physical and environmental protection policy. This policy must explain its purpose, where it applies, who is responsible for what (including the Physical Security Officer, Facility Security Officer, and Security Engineering Lead), how senior leadership is committed, how different teams will work together, and how compliance will be checked. It must also align with all relevant laws, directives, regulations, and internal standards.

The organisation must appoint the chief information security officer (CISO) (or a delegated Physical Security Policy Owner) to manage producing, recording, and sharing the policy and supporting procedures with the CISO, chief information officer (CIO), Facility Security Officers, operational technology (OT) site managers, and all security programme leads.

The policy must be reviewed and updated at least every year, and also after security incidents, audit findings, significant changes in risk, or updates to regulations or internal policy. The procedures must be reviewed and updated at least every year, and also after security incidents, audit findings, major changes to facilities, or changes to applicable laws or directives. The procedures must be shared with Facility Security Officers, Physical Security Officers, OT site managers, and system security officers.

##### Authoritative PE policy pack with owned review and controlled dissemination

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Draft organisation-level PE policy pack (policy + linked procedure modules covering secure areas, visitor/vendor access, escorting, CCTV/monitoring handling, environmental protections, facility access control, and physical event incident/breach coordination) | Compliance Manager | Enterprise | 40h | — |
| Define governance workflow: ownership model, approval steps, contributor roles (Security + Privacy), and controlled change management for policy/procedures | Project Manager | Enterprise | 16h | — |
| Establish dissemination plan and recipient mapping (policy recipients vs procedure recipients) including acknowledgement requirements and communication channels | Service Delivery Manager | Enterprise | 12h | — |
| Configure controlled repository publishing: versioning, access controls, document naming conventions, retention of approval/review/dissemination evidence | Operations Lead | Enterprise | 24h | £2,500 |
| Create and implement review/update cadence with trigger-event handling (annual review + updates after incidents/audit findings/material risk/regulatory changes), including evidence templates | Compliance Manager | Enterprise | 20h | — |
| Run initial cross-functional review and approval cycle (Security programme leads, Privacy stakeholders, CIO representative, FSO/PSO, OT site managers, Security Engineering Lead) and produce final approved pack | Cyber Security Lead | Enterprise | 28h | — |
| Deliver training/briefing for named dissemination audiences and confirm acknowledgement records for policy and procedures | Service Delivery Manager | Enterprise | 16h | — |

**Total Estimated Effort:** 156h  
**Total Estimated Cost:** £2,500

###### Actions Required for Compliance

- [ ] Draft an organisation-wide policy pack for physical and environmental protection, including its purpose, scope, responsibilities (physical security officer (PSO), facilities security officer (FSO), and Security Engineering Lead), how these roles coordinate, and the approach for meeting compliance requirements.
- [ ] Appoint the Chief Information Security Officer (CISO) — or the delegated Physical Security Policy Owner — as the named person responsible for managing the policy and its procedures.
- [ ] Publish the policy and procedures in a controlled document repository with version history and an approval workflow.
- [ ] Share the policy with the Chief Information Security Officer (CISO), Chief Information Officer (CIO), Field Security Officers (FSOs), operational technology (OT) site managers, and all security programme leads, and record proof that they have acknowledged it.
- [ ] Share the procedures with financial security officers (FSOs), programme security officers (PSOs), operational technology (OT) site managers, and system security officers, and record proof that they have acknowledged receipt.
- [ ] Set review and update schedules: review the policy every year and after any trigger event; review the procedures every year and after any trigger event.
- [ ] Set up a process to collect trigger events—such as audit findings, security incidents, major changes to facilities, and updates to regulations—and send them into the review workflow.


---

### PE-2 — Physical Access Authorizations (Control)

This requirement ensures that only the correct people can physically enter the building where the system is kept, and that their access remains up to date. Without a clear, approved list and regular checks, former staff, contractors, or the wrong people could still have badges or access cards, which could allow unauthorised entry to sensitive areas and increase the risk of theft, disruption, or misuse.

To meet this requirement, the organisation must create, formally approve, and keep up to date a written or electronic list of everyone authorised to access the site, including which areas each person can enter. The organisation must only issue site access credentials—such as identity (ID) badges, identification cards, or smart cards—to people on that list. It must set the appropriate level of credential strength in line with relevant rules and policies. It must review the authorised access list at least every 90 days, and promptly remove anyone whose access is no longer needed by revoking or disabling their credentials.

Visitors must be managed through the visitor authorisation process. People with permanent access must be treated as authorised personnel and included in the list.

##### Authorised facility access list with automated badge issuance/revocation

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define authoritative Authorised Facility Access List data model (person, status, access level, permitted areas/doors/access groups) and mapping to credential types/door groups | System Design Authority | Enterprise | 24h | — |
| Establish controlled governance workflow for list approvals (named approvers, approval records, audit fields, segregation of duties rules, evidence retention) | Compliance Manager | Enterprise | 32h | — |
| Implement integrations for joiner/mover/leaver and contractor lifecycle feeds (HRIS/contractor management → access request/list membership events) | IAM Engineer | Enterprise | 56h | — |
| Configure/extend physical access management platform integration for automated badge issuance, updates, and immediate disablement on removal (badge ID ↔ person ↔ access level ↔ timestamps) | Platform Engineer | Enterprise | 72h | £25,000 |
| Implement 90-day recertification process (review task generation per access group, reviewer confirmations, outcomes, evidence capture, exception handling) | Operations Lead | Enterprise | 40h | — |
| Define and implement credential strength rules by area risk (authentication assurance/credential technology selection, restricted-area overrides, validation controls) | Security Engineer | Enterprise | 24h | — |
| Visitor handling controls (ensure visitors use separate visitor authorisation process; prevent permanent list misclassification; reporting/audit checks) | Compliance Manager | Enterprise | 24h | — |

| Total Estimated Effort |  |  | **272h** |  |
| Total Estimated Cost |  |  |  | **£25,000** |

###### Actions Required for Compliance

- [ ] Define the official facility access information—who each person is, their access level, and which areas/doors they are allowed to use—and link each access group to the relevant physical doors.
- [ ] Set up a controlled process to create and approve the Authorised Facility Access List, with named approvers and records showing the approval evidence.
- [ ] Integrate human resources information system (HRIS) and contractor start/transfer/end updates into the workflow so that access lists are automatically updated for joiners, movers, and leavers.
- [ ] Link the approved list process to the physical access management system to automate issuing access badges, updating them, and disabling access when needed.
- [ ] Set up 90-day access reviews for each access group, and require written confirmation from the reviewer that the person still needs access and meets the eligibility requirements.
- [ ] Set a policy for how strong badge and authentication checks must be, based on the risk level of each area, and apply this policy when issuing badges.
- [ ] Set up visitor authorisation as a separate process, so visitors are not added to the permanent list of members.


---

#### PE-2.1 — Access by Position or Role (Enhancement)

This requirement is about making sure only the right people can physically enter the building where the system is kept, based on their job. Without this, unauthorised staff, contractors, or visitors could enter sensitive areas, interfere with equipment, or disrupt services simply because access was given for convenience rather than need.

To meet this expectation, the organisation must set clear rules that link each position or role to specific entry and exit points for the facility. It must also include authorised permanent and routine maintenance staff, duty officers, and emergency medical staff.

The organisation must keep up-to-date records showing which roles are allowed to use which doors or routes. It must also maintain written procedures for how these permissions are approved, recorded, updated when roles change, and removed when people leave.

The organisation should ensure that access activity is logged at the relevant entry and exit points, so permissions can be checked against actual use.

##### Role-to-door access matrix with approval and PACS enforcement

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define facility boundary and authoritative list of system-facility entry/exit points (doors/gates/controlled routes), including scope for routine maintenance, duty officers, and emergency medical staff | System Design Authority | Enterprise | 24h | — |
| Produce initial role-to-entry/exit-point access matrix (version-controlled), including required role types and explicit mapping to each door/controller-controlled route | Compliance Manager | Enterprise | 32h | — |
| Define controlled authorisation lifecycle (request, eligibility validation, approval, implementation, effective dates, and revocation triggers) and publish operating procedure | Project Manager | Enterprise | 16h | — |
| Configure PACS enforcement using role groups (no ad-hoc per-person overrides): implement role-group naming convention, map matrix entries to door controller permissions, and enable/verify access logging at relevant points | Physical Access Control Administrator | Department | 40h | £6,000 |
| Implement joiner/mover/leaver and role-change handling: define HR/identity role-change event workflow and ensure PACS role-group membership updates align to the authorisation lifecycle | Operations Lead | Enterprise | 32h | — |
| Establish audit-ready evidence retention: define record set for matrix versions/approvals and access-log retention, and implement evidence capture/reporting workflow for audits | Data Protection Officer | Enterprise | 24h | £2,500 |
| Update system security plan and governance documentation to reference the matrix, PACS enforcement mechanism, responsibilities, and review cadence | Compliance Manager | Enterprise | 16h | — |

**Total Estimated Effort:** 204h  
**Total Estimated Cost:** £8,500

###### Actions Required for Compliance

- [ ] Create an official list of all facility entry and exit points that sit on the system’s facility boundary.
- [ ] Define and publish a matrix showing which roles are allowed to enter and leave through each access point, including routine maintenance staff, duty officers, and emergency medical staff.
- [ ] Set up a controlled process for role-based access authorisation: request access, validate the need, approve the request, record the decision, implement the access, and review it.
- [ ] Set up the door controllers and public address and control system (PACS) to control access using role groups that match the access matrix, with no unmanaged individual (per-person) exceptions.
- [ ] Set up “joiner, mover, leaver” triggers to update and remove physical access when people’s roles change
- [ ] Enable and keep physical access logs at every relevant entry and exit point, and link the evidence to the authorised role basis.
- [ ] Update the system security plan to refer to the matrix, the picture archiving and communication system (PACS) enforcement mechanism, and the responsibilities.


---

#### PE-2.2 — Two Forms of Identification (Enhancement)

This requirement is about making sure visitors prove who they are twice before being allowed into the building where the organisation’s systems are kept. It matters because if someone could enter with only one proof of identity, the wrong person could get onto the site, interfere with equipment, or create a starting point for wider harm.

To meet this expectation, the organisation must require visitors to show two forms of identification selected from: a passport, a REAL ID-compliant drivers’ licence, a personal identity verification (PIV) card, a key card, a PIN, or biometrics such as a fingerprint or face recognition. The organisation must apply this “two forms of identification” rule for access to that specific facility.

For automated entry, the organisation should allow entry using the approved options that match the access method, including personal identity verification (PIV) cards and/or key cards, and where appropriate a PIN and/or biometrics.

##### Enforce two-ID visitor admission for the system facility

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Confirm PE-2(2) two-ID requirements and define the operational “approved ID set” mapping from `param pe-02.02_odp` (including allowed combinations for automated mechanisms) | Compliance Manager | Enterprise | 16h | — |
| Update/extend Visitor Management System (VMS) data model and configuration to store: ID type(s), verification status (“two-ID verified”), verifier identity (where applicable), timestamps, and facility/zone scope | System Design Authority | Department | 40h | — |
| Implement visitor check-in workflow enforcement: require two distinct approved ID types before credential/pass issuance/activation; validate and record evidence items; block issuance on invalid/insufficient combinations | Software Lead | Department | 56h | — |
| Integrate VMS “two-ID verified” state with physical access control (door/gate controllers): ensure access authorisation is conditional on correct facility/zone scope and deny when state is not satisfied | Infrastructure Lead | Department | 48h | — |
| Configure automated access mechanism rules (e.g., PIV/key card plus optional PIN/biometrics) and ensure controller-side enforcement aligns with the approved set and “two-ID verified” status | Security Engineer | Team | 32h | — |
| Implement audit-ready logging and evidence export: two-ID verification event, ID types presented, timestamps, verifier identity (if used), and resulting door/access events; ensure retention and SIEM ingestion | Operations Lead | Enterprise | 40h | £3,000 |
| Build and execute test evidence: valid combination acceptance, invalid attempt denial (e.g., one ID type), facility/zone scoping checks, and automated gate behaviour; produce audit pack | Quality Assurance Lead | Department | 32h | — |

**Total Estimated Effort:** 264h  
**Total Estimated Cost:** £3,000

###### Actions Required for Compliance

- [ ] Set up the visitor management process so that, before any access credentials are issued or activated, it requires exactly two different types of identification from **pe-02.02_odp**.
- [ ] Set up facility and zone scoping so each issued credential authorises access only to the facility where the system is located.
- [ ] Link the video management system (VMS) credential activation status to door and gate access control, so entry is refused unless the status is marked “two-ID verified”.
- [ ] Allow automated processes by matching the permitted combinations to a personal identification verification (PIV) card or key card, and optionally to a personal identification number (PIN) and/or biometrics, using the approved set.
- [ ] Record and keep audit logs showing the two identification types used, the verification result, the date and time, and the resulting access authorisation and door events.
- [ ] Test valid two-identifier combinations and invalid single-identifier attempts to confirm the rules are enforced at both check-in and entry points.


---

#### PE-2.3 — Restrict Unescorted Access (Enhancement)

This expectation is about keeping the room where the system is housed secure and locked down, so only the right people can enter without being supervised. If unsupervised entry is allowed too widely, unauthorised staff or visitors could see sensitive information, interfere with it, remove it, or disrupt the system in ways that may be difficult to detect later.

To meet this expectation, the organisation must keep an up-to-date, documented list of everyone who is allowed to enter the facility without an escort. This permission must be formally approved for all information held by the system, not just part of it. Anyone who does not have the required formal authorisation, security clearance, and a demonstrated need to know must be escorted at all times by staff who are themselves authorised to escort and to enter without an escort.

The organisation must also keep records of who is authorised, who accessed the facility and when. Access credentials must be issued only to authorised people and promptly withdrawn when permissions change or end.

##### Unescorted access enforced via “all-information” badge authorisation

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define the “all-information” in-scope information asset model for the facility decision (apps, databases, admin consoles, data stores, hosted services) and produce a traceable mapping to the system security plan | Compliance Manager | Enterprise | 24h | — |
| Create/extend the authoritative authorisation record schema and data model (person ↔ system(s) ↔ information-scope coverage ↔ validity dates ↔ approval evidence) including data quality rules and lifecycle (create, amend, expire, revoke) | Data Protection Officer | Enterprise | 32h | — |
| Implement policy-as-code decision logic to compute `unescorted_allowed` (true only when authorisation is currently valid and covers 100% of in-scope information for the system) with versioning and test cases | Software Lead | Department | 56h | — |
| Build attribute provisioning from authorisation records to the access decision point (IdP/PDP) so PACS can consume `unescorted_allowed` and escort eligibility attributes reliably across environments (prod/test/DR) | Platform Engineer | Enterprise | 40h | — |
| Configure PACS door/area rules and escort workflow: deny unescorted entry when `unescorted_allowed=false`; trigger escort-required flow; enforce that escort identities must have required physical access authorisations and be currently valid | Operations Lead | Department | 40h | £18,000 |
| Implement auditable physical access logging enhancements (unescorted vs escort-assisted, identity, door/area, timestamp, escort identity when applicable) and integrate with SIEM for retention and alerting | Security Engineer | Enterprise | 32h | £6,000 |
| Produce audit-ready governance pack: link policy decision logic version + “all-information” scope mapping to the security plan; define evidence collection runbook and periodic review cadence | Compliance Manager | Enterprise | 24h | — |

**Total Estimated Effort:** 248h  
**Total Estimated Cost:** £24,000

###### Actions Required for Compliance

- [ ] Define which information assets are in scope for the facility access decision.
- [ ] Create and approve a formal record of the “all-information” authorisation scope for each person.
- [ ] Set the policy rule for `unescorted_allowed` only when the authorisation covers all information that is within scope.
- [ ] Use the calculated attribute when setting up the badge in the physical access control system (PACS), so door access is automatically enforced.
- [ ] Set up the picture archiving and communication system (PACS) escort process so that people who are not authorised cannot enter without an escort, and ensure an escort identity is always required.
- [ ] Enable and keep physical access logs that record whether a person was unescorted or escorted, and—if escorted—the identity of the escort.
- [ ] Update the system security plan by adding links to the evidence that shows how the scope mapping and the policy decision logic version were used.


---

### PE-3 — Physical Access Control (Control)

This requirement is about making sure only authorised people can physically enter your building and sensitive areas, and that you can prove who went where. Without it, unauthorised visitors, staff, or intruders could enter through entrances, vehicle access points, loading areas, or restricted rooms, and then access valuables, systems, or information.

To meet this expectation, the organisation must check each person’s permission to enter before allowing access at the main entrance, vehicle gate, loading bay, and every interior restricted-area door. It must also control entry and exit at these points using security staff (guards). The organisation must keep records of door access for all external doors, loading bay doors, and restricted-area interior doors. For areas that are open to the public, it must prevent unauthorised movement from public areas into non-public areas by using badge-controlled entry, staffed reception or guards at the handover from public to secure areas, and access logs for non-public doors.

All visitors to non-public areas must be escorted at all times, and their entry and exit must be recorded. The organisation must securely manage keys, locks, access cards, and card readers, keep an inventory of them every quarter, and change lock combinations immediately if keys or combinations are lost, compromised, or when the holder leaves or is transferred—otherwise at least every 12 months. Keys must be changed immediately if lost, or when the holder leaves or is transferred—otherwise at least every 12 months.

##### Integrated PACS access authorisation, visitor escort, and audit logs

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define PACS access-point model (entry/exit points, door/reader mapping, and “public-to-non-public transition” classifications) and produce configuration specification for main entrance, vehicle gate, loading bay, and restricted-area doors | Facilities Security Manager | Enterprise | 24h | — |
| Implement authorisation verification rules per door/point (door-controller configuration, credential-to-door authorisation enforcement, and real-time revocation behaviour on transfer/termination) | Security Engineer | Enterprise | 40h | — |
| Configure visitor escort workflow integration (check-in/reception trigger, escort session state, enforcement of “no unescorted access” for non-public areas, and temporary escort-scoped authorisations) | Platform Engineer | Enterprise | 48h | — |
| Enable and validate physical access audit logging for all required doors/points (exterior doors, loading bay doors, interior restricted-area doors) including event types for granted/denied and failed attempts; define log schema and required fields | Security Engineer | Enterprise | 32h | — |
| Integrate PACS logs to approved logging/SIEM pipeline with integrity protections (restricted admin access, tamper-evident storage where available, normalisation, and evidence-ready retention configuration) | Operations Lead | Enterprise | 32h | £12,000 |
| Implement monitoring and alerting for PE-3-relevant events (e.g., repeated denied attempts, visitor escort failures, unexpected access patterns) and confirm alert routing to SOC | Service Delivery Manager | Enterprise | 24h | £6,000 |
| Execute end-to-end testing and audit evidence pack (test scripts, access scenarios, visitor escort scenarios, log completeness checks, and production readiness sign-off) | Quality Assurance Lead | Enterprise | 40h | — |

**Total Estimated Effort:** 260h  
**Total Estimated Cost:** £18,000

###### Actions Required for Compliance

- [ ] Identify and record every defined entry and exit point in the physical access control system (PACS), including the main entrance, vehicle gate, loading bay, and doors inside restricted areas.
- [ ] Integrate the picture archiving and communication system (PACS) with the organisation’s official identity and access approval system to control entry by door and to immediately remove access when someone is transferred or their employment ends.
- [ ] Set up badge-controlled entry from public areas to secure areas, and apply a rule that prevents visitors from accessing non-public doors unless the required escort process conditions have been met.
- [ ] Set up and centralise automated records of physical access checks for all exterior doors, loading bay doors, and doors inside restricted areas, including records of denied entry events.
- [ ] Set up a visitor process that requires an escort at all times, and record when visitors enter and leave non-public areas.
- [ ] Check that logs are complete and kept for the required time by testing the full process of producing evidence for a sample of access events and visitor sessions.


---

#### PE-3.1 — System Access (Enhancement)

This requirement is about making sure only the right people can physically enter the areas where the organisation’s most important system equipment is kept, such as the server room, the secure network equipment room, and any dedicated data centre cage. Without this, someone who should not be there could tamper with or steal equipment, disrupt services, or gain access that could lead to wider harm.

To meet this expectation, the organisation must clearly define these protected areas, allow entry only to people who have been formally approved to access them, and provide the correct entry credentials (such as access badges, keys, or an equivalent method) that match that approval. It must also apply the right physical security measures for each area, control and identify who enters and leaves through each entry and exit point, and keep records of access attempts so they can be checked later.

Clear responsibilities must be assigned, procedures must explain how access is granted, reviewed, and removed, and the approach must be documented in the system plan.

##### Enforce area-specific physical access authorisations for system rooms

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Confirm scope for **pe-03.01_odp** and produce an authoritative list of system-protected physical spaces (server room, secure network equipment room, dedicated data centre cage) with mapped entry points/doors | Compliance Manager | Enterprise | 16h | — |
| Design access control model: create distinct zones/door groups per system-protected area and define credential-to-area binding rules (deny-by-default for system areas) | System Design Authority | Enterprise | 24h | — |
| Configure access control system: implement zone/door granularity, update controller/access group mappings, and enforce area-specific authorisation checks for each system area | Infrastructure Lead | Department | 32h | — |
| Implement authoritative authorisation workflow integration: configure issuance and revocation triggers from IAM/HR/ticketing so approvals grant only the approved area(s) and removals revoke within the defined operational window | DevOps Lead | Enterprise | 40h | — |
| Enable and centralise physical access event logging: ensure controller logging includes person/credential ID, door/entry point, mapped system area, and grant/deny outcome; forward to SIEM with required fields and retention | Security Engineer | Enterprise | 24h | £8,000 |
| Build periodic access review capability for each system area: run scheduled reconciliation, generate review packs, and define discrepancy handling (e.g., credential active but authorisation removed) | Compliance Manager | Enterprise | 24h | — |
| Document operational procedures and evidence pack: authorisation lifecycle runbook, responsibilities/RACI, review cadence, and audit-ready evidence templates for PE-3(1) | Data Protection Officer | Enterprise | 16h | — |

**Total Estimated Effort:** 196h  
**Total Estimated Cost:** £8,000

###### Actions Required for Compliance

- [ ] Set up separate access control areas (door groups) for each physical location listed in **pe-03.01_odp**.
- [ ] Set the door controller rules so that each credential (for example, a card or code) only works for the relevant area access group(s).
- [ ] Link badge and key issue and cancellation to the approved physical access authorisation process
- [ ] Turn on logging of controller events and send those events to the security information and event management (SIEM) system, including the door, area, credential or person ID, and whether access was granted or denied.
- [ ] Carry out and record regular access reviews for each system area, and fix any differences found.
- [ ] Publish and keep up-to-date procedures for the full authorisation process—request, approval, issue, change, review, and revocation—assigning named responsibilities to specific roles.


---

#### PE-3.2 — Facility and Systems (Enhancement)

This requirement is about making sure the outer boundaries of your site are checked regularly, so that people cannot quietly take information or equipment out without permission. If these checks are not carried out, someone could take advantage of weak points such as gates, loading bays, external doors, or other entry and exit routes around the site to steal hardware, remove parts of systems, or move sensitive information out of the facility.

To meet this expectation, the organisation must carry out security checks along the physical perimeter of the facility or system every day during 24/7 operations, and also after any change to the perimeter (for example, new fencing, changes to access points, or construction work) or after any security incident.

Named, responsible staff must follow documented procedures for inspecting the perimeter for signs of tampering, forced entry, or gaps that could allow removal or unauthorised movement. They must also keep clear records showing when, where, and by whom the checks were completed, including evidence of what was checked and any follow-up actions taken.

##### Daily perimeter security checks with zone coverage and tamper-evident logs

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define perimeter coverage model (zones + enumerated checkable entry/exit points) mapped to facility/system layout documentation | Security Engineer | Enterprise | 24h | — |
| Produce documented inspection procedure and checker guidance (observable indicators for exfiltration/component removal; evidence requirements; completion criteria) | Compliance Manager | Enterprise | 32h | — |
| Design shift-based operational workflow for 24x7 daily execution, including automated re-issue after perimeter change and security incident triggers | Project Manager | Enterprise | 40h | — |
| Implement tamper-evident, append-only logging for each check (schema, retention, integrity controls, restricted modification, audit export) | Platform Engineer | Enterprise | 56h | £18,000 |
| Configure evidence capture and follow-up enforcement (mandatory photo/notes for anomalies; incident/ticket linkage; workflow gating until reference created) | Operations Lead | Enterprise | 40h | £6,000 |
| Integrate triggers and identity controls (perimeter-change + incident events; authorisation for named checkers/supervisors; access to complete checks) | DevOps Lead | Enterprise | 32h | £4,000 |
| Run pilot, tune zone coverage/frequency, and deliver audit-ready evidence pack demonstrating daily checks + post-change/incident checks | Quality Assurance Lead | Enterprise | 24h | — |

Total Estimated Effort: **248 Hours**  
Total Estimated Cost: **£28,000**

###### Actions Required for Compliance

- [ ] Define the perimeter zones and list every entry and exit point that can be checked, mapped to the facility or system layout documentation.
- [ ] Create a documented perimeter inspection procedure that identifies signs of information being taken out of the organisation and signs of system components being removed.
- [ ] Set up a shift-based process that creates and assigns daily perimeter inspection tasks during 24 hours a day, 7 days a week operations.
- [ ] Automate re-checking of perimeter security after changes to the perimeter and after security incidents
- [ ] Set up tamper-evident, append-only logging for every check, with required (mandatory) information fields and restricted write access.
- [ ] When anomalies are detected, require evidence to be captured (for example, photos or notes) and ensure there is a mandatory link to a follow-up action.


---

#### PE-3.3 — Continuous Guards (Enhancement)

This requirement is about having trained security staff physically present to stop unauthorised people from entering the areas where your systems are kept, all day and every day. Without continuous cover at the main entrance, the server room entrance, the loading dock access points, and the perimeter gate access points, someone could enter unnoticed, tamper with equipment, or gain access during quieter periods when checks are weakest.

To meet this expectation, the organisation must ensure guards are on duty 24 hours a day, 7 days a week at each of these entry points, and that their role, responsibilities, and working practices are clearly documented. It must name the people responsible for these duties, keep records showing when guards were present and what they did, and keep evidence that the site is monitored to support the guards’ work.

The organisation must also ensure guards are trained and formally authorised to carry out access checks, and that the server room and perimeter gates have immediate, documented responses to any access incidents.

##### 24/7 guards at defined facility access points with auditable patrol logs

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Produce the guard coverage map for all defined access point categories (main entrance, server room entrance, loading dock access points, perimeter gate access points) including door/gate-to-system entry/exit mapping and coverage boundaries | Facilities/Security Operations Lead | Enterprise | 24h | — |
| Draft access-point-specific guard SOPs (identity/authorisation checks, visitor/delivery workflows, escort rules for server room and perimeter gates, escalation/denial criteria, and incident reporting triggers) | Compliance Manager | Enterprise | 40h | — |
| Define and implement the 24/7 roster model (shift patterns, named roster, holiday/weekend coverage, handover checklist, supervisor sign-off workflow, and gap prevention controls) | Project Manager | Enterprise | 32h | — |
| Configure and operationalise electronic patrol/presence logging (device/process selection, check-in locations, time-stamping, guard attribution, denied-entry/event logging, and audit trail requirements) | Security Engineer | Enterprise | 24h | £6,000 |
| Establish audit-ready evidence retention package (linking roster/assignment, patrol logs, and incident/response records; define retention schedule and access controls for audit retrieval) | Data Protection Officer | Enterprise | 16h | — |
| Train and formally authorise guards for these duties (initial + refresher training content, competency checks, authorisation records, and periodic revalidation cadence) | Quality Assurance Lead | Enterprise | 24h | £4,000 |
| Run go-live readiness and first audit rehearsal (table-top and live walk-throughs for each access point type; verify no coverage gaps; validate log completeness and incident workflows) | Service Delivery Manager | Enterprise | 16h | — |

Total Estimated Effort: **196 Hours**  
Total Estimated Cost: **£10,000**

###### Actions Required for Compliance

- [ ] Document and get approval for the list of authorised access points for the facility, mapped to each physical entry and exit location (main entrance, server room entrance, loading dock access points, and perimeter gate access points).
- [ ] Create standard operating procedures (SOPs) for each type of access point. Each SOP should cover: checks to confirm identity and permission to enter, how visitors and deliveries are handled, when an escort is required, and the rules for escalation or refusal of access.
- [ ] Set up a named 24/7 rota with shift handover checklists to prevent any missed coverage at all agreed access points.
- [ ] Set up electronic patrol and presence records with time stamps, where staff must check in at specific locations, and where incidents are recorded automatically when they occur.
- [ ] Keep training records and formal authorisation records for guards carrying out these duties, including the server room procedures and the perimeter gate procedures.
- [ ] Define and keep an audit-ready set of evidence that links staff rosters and assignments, patrol logs, and incident and response records.


---

#### PE-3.4 — Lockable Casings (Enhancement)

This requirement is about keeping work phones, tablets, and portable notebook computers physically secure by storing them in lockable storage. It matters because the biggest real-world risk with portable devices is theft or unauthorised handling. If equipment can be taken from desks, rooms, or shared areas, sensitive work information can be exposed, and the organisation can face disruption and extra cost.

To meet this expectation, the organisation must protect every work-used portable notebook computer, tablet, and smart phone by storing it in a suitable lockable case (for example, a lockable cabinet or enclosure) whenever it is not being used under authorised supervision. The organisation must also:

- keep a documented list of which devices require this protection  
- set out clear procedures for who can access the locked cases and how access is controlled  
- include these responsibilities in its physical protection policy and system security planning  
- keep records showing the approach is in place and is being followed

##### Lockable casings for work portable devices when unattended

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define PE-3(4) lockable casing scope: create and approve the auditable device-to-casing register template (asset tag/serial, owner, location, casing required flag) | Compliance Manager | Enterprise | 16h | — |
| Populate and validate the device register for all work portable notebooks/tablets/smart phones requiring casing protection (including reconciliation with IT Asset Management) | IT Asset Management Lead | Enterprise | 24h | — |
| Select and standardise casing types by use case (single-device enclosures vs multi-device cabinets) and define minimum physical security requirements (cable lock/lockdown plate support, tamper resistance, placement rules) | System Design Authority | Enterprise | 20h | — |
| Procure lockable casings and accessories (single-device enclosures, multi-device cabinets, cable locks/lockdown plates, signage, mounting hardware) sized to agreed locations and device counts | Infrastructure Lead | Enterprise | 8h | £18,000 |
| Install casings at approved locations and label them (including spares storage areas) with documented placement evidence (photos/location list) | Operations Lead | Department | 24h | £2,500 |
| Implement managed access to casings: establish key register/issuance-return process and/or configure electronic locks with controlled access and audit logging; define authorised roles and delegation rules | Security Engineer | Enterprise | 24h | £6,000 |
| Publish and enforce the “unattended → locked” operating procedure (including definition of authorised supervision, user instructions, exceptions handling, and escalation) and update the system security plan | Project Manager | Enterprise | 20h | — |
| Establish audit evidence and verification cadence: monthly spot-checks, reconciliation of key/lock access records, retention of evidence pack, and corrective action workflow | Compliance Manager | Enterprise | 28h | — |

**Total Estimated Effort:** 164h  
**Total Estimated Cost:** £26,500

###### Actions Required for Compliance

- [ ] Create and keep an auditable record of all devices for **PE-03.04_ODP** (work portable notebooks, tablets, and smart phones), including each device’s **location** and whether **the casing is required**.
- [ ] Choose and standardise lockable housing types (single-device enclosures and multi-device cabinets), and set out when cable locks and lockdown plates are required.
- [ ] Install protective casings in every location identified as an unattended-risk area, and label each one with the required storage procedure.
- [ ] Publish and train the “unattended → locked in casing” procedure, including definitions of authorised oversight and how to handle exceptions.
- [ ] Implement controlled access to casings using managed keys or electronic locks, with access limited to authorised roles and with access records kept for evidence.
- [ ] Update the system security plan to set out the casing standards, who is responsible for them, and how compliance will be checked for PE-3(4).
- [ ] Carry out and record regular physical spot checks to confirm that devices are kept in locked cases when they are not being used.


---

#### PE-3.5 — Tamper Protection (Enhancement)

This expectation is about making sure important hardware cannot be quietly opened, moved, or changed without leaving clear evidence. If someone interferes with the devices that protect your network, manage industrial systems, or provide security services, they could get around protections, introduce harmful changes, or swap equipment using supply-chain deception—without you noticing until after damage has been done.

To meet this expectation, the organisation must use tamper-evident seals, tamper-detection switches, and anti-tamper coatings on the relevant network security devices, operational technology (OT) control gateways, and server hardware that hosts security services. It should use detection only on some components, and both detection and prevention on others where appropriate.

The organisation must also:
- document which safeguards apply to which components
- include this approach in its physical protection policy and system security plan
- define procedures and named responsibilities for physical access and for overseeing information security
- ensure supporting measures are in place
- keep records showing the safeguards are applied, checked, and followed up when tampering is detected

##### Tamper-evident seals and tamper detection on security hardware

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define authoritative asset-to-technology coverage mapping (detection vs detect+prevent) for network security appliances, OT control gateways, and server hardware hosting security services, including rationale and risk-based selection criteria | Compliance Manager | Enterprise | 24h | — |
| Produce installation standards for tamper-evident seals, tamper-detection switches, and anti-tamper coatings (where selected), including access point definitions, serialisation/traceability rules, and minimum evidence requirements | Security Engineer | Enterprise | 20h | — |
| Create and approve operational workflow for tamper events (seal break / switch alert): isolation steps, incident/ticket creation, forensic/inspection steps, and return-to-service verification and re-sealing criteria | Security Operations Lead | Enterprise | 16h | — |
| Implement tamper-evident seals across covered device models (procure standardised seals, apply at defined access points, record device identifier ↔ seal serial/status) | Infrastructure Lead | Department | 40h | £6,000 |
| Install tamper-detection switches on selected components and validate alerting behaviour (configure switch-to-alert path, test disturbance scenarios, confirm actionable alert generation) | Operations Lead | Department | 32h | £4,500 |
| Apply anti-tamper coatings (detect+prevent selection for server hardware hosting security services) and record coating application evidence and device identifiers | Infrastructure Lead | Department | 24h | £3,500 |
| Establish inspection cadence and evidence retention process (inspection schedule, inspection record template, photo/evidence capture guidance, retention period alignment, and audit readiness checks) | Compliance Manager | Enterprise | 18h | — |
| Run end-to-end compliance validation (sampling-based audit of mapping coverage, seal/switch/coating records, workflow effectiveness, and evidence completeness) and remediate gaps | Quality Assurance Lead | Enterprise | 20h | — |

**Total Estimated Effort:** 194h  
**Total Estimated Cost:** £13,?00

###### Actions Required for Compliance

- [ ] Create a definitive list of all covered assets (network security appliances, operational technology (OT) control gateways, and servers that host security services), including their physical locations.
- [ ] For each asset, record the decision on whether it will be detection-only or detection plus prevention, and specify the anti-tamper technologies that will be used.
- [ ] Fit tamper-evident seals to the specified access points for each covered device model, and record the seal identifiers and their status.
- [ ] Fit tamper-detection switches to selected components and confirm that any disturbance or movement triggers alerts that can be acted on.
- [ ] Apply anti-tamper coatings to selected server hardware where the organisation has chosen prevention measures and will record evidence of the application.
- [ ] Set up and run a tamper response workflow—**isolate**, **investigate**, **verify**, and then **re-seal or restore**—with clearly named responsibilities.
- [ ] Set up an inspection schedule based on risk, and keep evidence that is ready for audit (such as inspection records and photos where possible).


---

#### PE-3.7 — Physical Barriers (Enhancement)

This requirement is about using strong, physical protection—such as bollards, concrete slabs, jersey barriers, or hydraulic vehicle barriers—to prevent people or vehicles from entering areas where they should not. Without these safeguards, someone could accidentally or intentionally reach sensitive areas and systems, which could lead to theft, disruption, or unauthorised access.

To meet this expectation, the organisation must:
- limit access to the system by installing and using the correct physical barriers at the relevant entry points and access routes; and
- keep an up-to-date, documented list of which barriers are used and their locations.

The organisation must also:
- set out the physical access control procedures in its Physical and Environmental Protection Policy; and
- record the same procedures in its system security plan, ensuring the barrier list matches those procedures.

Finally, the organisation must clearly assign responsibility for physical access control and for overseeing information security, and keep supporting records showing that barriers are managed and maintained.

##### Barrier inventory and access-route mapping for system entry points

- Category: Manual
- Priority: High

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Confirm PE-3(7) physical barrier scope for the application: identify relevant environments (prod/test/DR) and enumerate all system-relevant physical access points/routes (perimeter gates, loading bays, comms/server room doors, etc.) | Compliance Manager | Enterprise | 16h | — |
| Define barrier inventory data model and evidence requirements (fields for barrier type, site ID + drawing grid/coordinate, protected access point/route, associated physical access control procedure reference, and inventory entry ID conventions) | System Design Authority | Enterprise | 12h | — |
| Create the auditable barrier inventory as a controlled single source of truth (template + versioning approach + access permissions for contributors/auditors) | Project Manager | Enterprise | 10h | — |
| Populate inventory using site surveys and architectural evidence: extract barrier locations from drawings/CAD/BIM exports, capture dated photographs, and record barrier type/location/protected route with cross-references to procedure references | Infrastructure Lead | Department | 40h | £1,500 |
| Establish inspection/maintenance cadence and operational verification workflow: define review frequency, inspection checklist format, maintenance/change record linkage to inventory entry IDs, and escalation triggers for discrepancies | Operations Lead | Department | 14h | — |
| Align documentation: update Physical and Environmental Protection Policy and the system security plan to reference the same barrier inventory/procedure rules, ensuring barrier lists and procedure references match with no mismatches | Compliance Manager | Enterprise | 18h | — |
| Document named responsibilities and governance: assign accountability for barrier effectiveness (facilities/security operations) and security oversight (security governance), and record RACI/ownership in the control evidence pack | Security Engineer | Enterprise | 10h | — |

Total Estimated Effort: **120h**  
Total Estimated Cost: **£1,500**

###### Actions Required for Compliance

- [ ] Identify and record every physical entry point and access route that could affect system operation across the production, test, and disaster recovery environments.
- [ ] Create a controlled barrier inventory template with fields for the barrier type, the location reference, and the protected access point or route.
- [ ] Build the inventory using on-site surveys, architectural drawings (computer-aided design/computer-aided building information modelling), and dated photographs.
- [ ] Update the Physical and Environmental Protection Policy to explain how access is restricted using the documented barriers.
- [ ] Update the system security plan so it refers to the same barrier inventory entries and procedure rules, to ensure everything stays consistent.
- [ ] Assign named responsibilities for ensuring barriers work effectively and for overseeing information security, and publish these responsibilities in the relevant governance documents.
- [ ] Set up and carry out a regular inspection and maintenance schedule, and keep records that refer to the barrier inventory entry reference IDs.


---

#### PE-3.8 — Access Control Vestibules (Enhancement)

This requirement is about setting up a small, secure “waiting area” at the main entrances to sensitive areas. This prevents people from entering simply by following an authorised colleague inside. Without this two-step entry, an unauthorised person could enter by walking in behind someone who has already been approved—a common issue known as tailgating—which could lead to theft, interference with equipment or records, or exposure of highly sensitive information and equipment.

The organisation must install access control vestibules at every main entrance to server rooms, classified storage areas, and areas where processing is controlled under the International Traffic in Arms Regulations (ITAR) and the Export Administration Regulations (EAR). Each vestibule must have two interlocking doors that cannot be opened at the same time. People may enter the secure area only after their physical access has been checked and approved.

The organisation must:
- keep an up-to-date list of all vestibule locations
- maintain clear written procedures for how the vestibules are used
- follow those procedures in practice
- include this approach in its system security plan
- assign named responsibilities for operating the vestibules and for oversight by information security staff

##### Automate interlocking vestibules at secure entry points

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Create/maintain the authoritative vestibule register mapped to all **pe-03.08_odp** locations (including area owners, door IDs, controller models, and acceptance evidence links) | Compliance Manager | Enterprise | 16h | — |
| Perform site surveys and produce installation/configuration design packs for each vestibule (door hardware compatibility, controller wiring approach, safety/life-safety constraints, and interlock state model) | System Design Authority | Enterprise | 24h | — |
| Configure interlocking door controller logic for each vestibule (Door A unlock only when Door B is confirmed closed/locked; timeouts; fault/door-held-open handling; emergency egress behaviour alignment) | Security Engineer | Enterprise | 40h | — |
| Integrate first-door credential verification with PACS (authorisation check gating vestibule entry; deny/hold second door until vestibule state indicates authorised presence; implement fail-safe behaviour) | Platform Engineer | Enterprise | 32h | — |
| Enable and validate monitoring/event logging for interlock state changes (open/held/denied/fault), ensure events flow to SIEM/physical security monitoring with required fields and retention tagging | Operations Lead | Enterprise | 24h | £6,000 |
| Commission, test, and evidence generation for all vestibules (interlock functional tests, tailgating/piggybacking resistance tests, fault scenarios, and audit-ready test records) | Quality Assurance Lead | Enterprise | 32h | — |
| Develop and approve SOPs and oversight responsibilities (normal operation, interlock fault handling, door-held-open, emergency egress, periodic checks) and update system security plan with vestibule approach and evidence sources | Compliance Manager | Enterprise | 20h | — |
| Procure and install vestibule hardware where required (interlocking door controllers, door status sensors, cabling/termination, and any controller licences/support contracts) | Infrastructure Lead | Enterprise | 24h | £45,000 |

| Total Estimated Effort | 232h |  |
|---|---:|---:|
| Total Estimated Cost |  | £51,000 |

###### Actions Required for Compliance

- [ ] Create and keep up to date a vestibule register that links each required secure area to the correct vestibule location (from pe-03.08_odp).
- [ ] Configure the door controllers for the physical access control system (PACS) so that only one vestibule door can be unlocked or opened at any one time, with clearly defined responses for faults and timeouts.
- [ ] Set up checks to verify credentials at the first door, and control the vestibule so the second door cannot be used to follow someone in (tailgating).
- [ ] Enable and centralise event logging for changes in interlock status, blocked (denied) attempts, and door-held or fault conditions, and route these events into the organisation’s monitoring workflow.
- [ ] Write and get approval for standard operating procedures (SOPs) for normal use and for exceptions (interlock fault, door held open, emergency exit). Assign named responsibilities for day-to-day operations and for oversight.
- [ ] Update the system security plan to include the vestibule locations, how the controllers behave, and where evidence is collected. Put the register under change control.


---

### PE-4 — Access Control for Transmission (Control)

This expectation is about protecting the physical parts that carry your organisation’s communications, such as network cabling, patch panels, wiring closets and telecommunications distribution frames. These must be kept locked and protected from unauthorised access. Without these safeguards, someone could interfere with the wiring, disrupt services, or listen in or change connections in ways that may be difficult to detect later.

To meet this expectation, the organisation must:
- clearly identify where these components are located
- allow access only to authorised personnel
- keep wiring closets locked when they are not in use
- physically protect cabling using conduit or cable trays (or an equivalent protection method)
- lock spare connection points or otherwise prevent them from being used
- apply tamper-evident seals where opening could occur

The organisation must also:
- document how physical access is controlled in its procedures and system security plan
- keep system design and facility wiring diagrams up to date
- maintain a list of the physical safeguards in place
- assign named responsibilities for physical access and for overseeing information security
- keep records that show these measures are carried out

##### Lock and protect MDF/IDF, patch panels, and spare jacks with seals

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Produce authoritative inventory/map of protected transmission locations (MDF/IDF, comms rooms, wiring closets, patch panel banks, telecommunications distribution frames) including room/rack identifiers and covered termination areas | Network/Telecom Engineering Lead | Enterprise | 24h | — |
| Define standard hardening design for physical access protection (conduit/cable tray routing or equivalent, enclosure boundaries, access point constraints) and produce implementation checklist | System Design Authority | Enterprise | 16h | — |
| Procure and install physical protection hardware for cabling pathways and access boundaries (conduit/cable trays, locked/enclosed access points, required fixings) | Infrastructure Lead | Enterprise | 40h | £18,000 |
| Procure and implement locked spare connection controls (locked patch panels and/or locked blanking plates and/or locked patch-cord management hardware) across identified spare/unused jacks | Infrastructure Lead | Enterprise | 32h | £9,000 |
| Procure and apply tamper-evident seals to relevant covers/access points; create and maintain a seal register template (seal ID, location, date applied, installer, reconciliation cadence) | Compliance Manager | Enterprise | 16h | £2,500 |
| Implement access and evidence operational procedure (request/approval workflow, seal-break handling, close-out verification, reconciliation checks, record retention requirements) and train authorised personnel | Compliance Manager | Enterprise | 20h | — |
| Perform initial verification and audit-ready evidence pack (site walkdowns, lock/seal effectiveness checks, update inventory/map, produce sign-off report for PE-4 readiness) | Security Engineer | Enterprise | 24h | — |

**Total Estimated Effort:** 172h  
**Total Estimated Cost:** £29,500

###### Actions Required for Compliance

- [ ] Create and keep up to date an inventory and map of all locations of protected system equipment and cabling, including main and intermediate distribution frames (main distribution frame (MDF) and intermediate distribution frame (IDF)), patch panels, wiring closets, and distribution frames.
- [ ] Install and check locked enclosures for all identified wiring cupboards and communications access points.
- [ ] Route and protect all cables using conduit and/or cable trays (or an equivalent physical protection method), and make sure all connection points are located within locked, restricted areas.
- [ ] Secure any spare or unused network ports by using locked patch panels, locked blanking plates, or locked patch-cord management equipment.
- [ ] Fit tamper-evident seals to any covers or access points that could reveal areas used for patching, spare network jacks, or cabling routes, and record each seal’s ID and location in a register.
- [ ] Set up and document an access and approval process, including what to do if a seal is broken, and carry out a final check after access is completed. Keep records that are suitable for audit.


---

### PE-5 — Access Control for Output Devices (Control)

This requirement is about keeping the results of work—what appears on screens, is printed, scanned, faxed, copied, or played through audio devices—out of reach of anyone who should not see or take it. Without this, confidential information could be viewed, copied, or removed by unauthorised visitors or staff, simply by getting close to an output device or by taking printed pages before they are collected.

To meet this expectation, the organisation must keep all these output devices in secure rooms or other secured areas. Entry must be controlled using a keypad or card-reader, and only authorised people may be allowed in. Devices must be placed so staff can monitor them. Where there is a realistic risk of someone nearby seeing the screen or hearing the audio, privacy screen filters and headphones (or equivalent measures) must be used.

The organisation must also keep up-to-date records of which devices and outputs are covered, document the procedures and the room layout, include this approach in its security plan, assign responsibility for controlling access and for oversight, and keep records of who accessed these secure rooms over time so access can be checked.

##### Secure output device rooms with controlled access and privacy measures

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Create and maintain the authoritative “covered output devices” register (asset ID/serial, device type, output types, verified physical location, owner, and room mapping) | Compliance Manager | Enterprise | 16h | — |
| Conduct site survey and confirm/designate secured “output rooms” for all covered devices, including room boundaries, access points, and staff visibility considerations | Infrastructure Lead | Enterprise | 24h | £2,000 |
| Implement physical access control for each output room (keypad/card reader installation, door hardware configuration, access group mapping to authorised personnel, and operational handover) | Operations Lead | Enterprise | 32h | £6,500 |
| Configure and validate audit-ready access logging/retention for each output room door (ensure logs are retrievable, time-synchronised, and retained per policy) | Security Engineer | Enterprise | 16h | £1,200 |
| Procure and install privacy/anti-shoulder-surfing measures (screen privacy filters for plausible side-view displays; headphones or equivalent for audio output devices) | Cyber Security Lead | Enterprise | 20h | £3,800 |
| Develop and document output handling operational procedures (prompt collection requirements, controlled collection point rules, escalation for access exceptions, and staff responsibilities) | Compliance Manager | Enterprise | 12h | — |
| Perform walkthroughs/spot checks and evidence pack assembly for audit readiness (device-to-room verification, access log samples, privacy measure verification, and procedure adherence checks) | Quality Assurance Lead | Enterprise | 18h | — |

**Total Estimated Effort:** 136h  
**Total Estimated Cost:** £14,500

###### Actions Required for Compliance

- [ ] Create and keep an up-to-date master list of all covered output devices linked to `pe-05_odp`, including their confirmed physical locations.
- [ ] Set up secured output rooms or areas and allow entry only for authorised people by using keypad and card-reader access controls.
- [ ] Move all covered output devices into the secure areas, and place them so staff can monitor how outputs are used and collected.
- [ ] Fit monitor or screen privacy filters and provide headphones (or an equivalent alternative) for audio output where people could realistically view the screen from the side or overhear the audio.
- [ ] Set up and document procedures for handling outputs (either collect them immediately or collect them at a controlled collection point) and train authorised staff.
- [ ] Enable and keep physical access control records for each secured output area, and capture evidence of the room layout for audit purposes.


---

#### PE-5.2 — Link to Individual Identity (Enhancement)

This expectation is about making sure sensitive documents are only released to the specific person who is authorised to receive them, at the point of printing, copying, or faxing. Without this, confidential information could be taken by the wrong person, left accessible on a machine, or sent to the wrong recipient—creating real risks such as data breaches, financial loss, and harm to individuals whose details are included in the documents.

To meet this requirement, the organisation must:
- keep an up-to-date list of which output devices, and which types of sensitive outputs, require identity-linked release; and
- configure those devices so that documents are held back until the requesting person proves they are the correct individual using an approved method.

The organisation must also:
- apply physical security controls to the areas where these devices are kept;
- keep records showing that access is controlled;
- keep records showing who released which document, and when; and
- document the approach in its systems and privacy planning, including any required privacy assessments and risk reviews.

##### Device secure release (hold-and-release) linked to individual identity

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Create an in-scope output device register (asset ID, location, model, supported auth methods, in-scope output types, secure queue mapping) and obtain sign-off from Security/Compliance | Compliance Manager | Enterprise | 24h | — |
| Select and standardise device authentication method(s) (badge/PIN/device login), define mapping approach from device-authenticated user to unique individual identity, and produce implementation guidance for device teams | System Design Authority | Enterprise | 32h | — |
| Configure secure hold-and-release on each in-scope printer/copier (deny release until successful auth; ensure release is restricted to authenticated user’s held jobs; validate no cross-user release) | Infrastructure Lead | Department | 80h | £12,000 |
| Integrate device authentication with central identity service (IdP) and implement user-to-identity mapping (including handling of contractors/contractor accounts and identity lifecycle edge cases) | IAM Lead | Enterprise | 56h | £8,000 |
| Standardise job submission for sensitive outputs (enforce secure/held queue routing via print management rules/config; document and implement controls to prevent bypass paths) | Operations Lead | Enterprise | 40h | £3,500 |
| Implement audit logging and retention (identity, device ID, job identifier/name, timestamp, release/denial outcome), forward logs to SIEM, and validate end-to-end audit trail completeness | Security Engineer | Enterprise | 48h | £6,500 |
| Implement physical access controls for device areas and retain access evidence aligned to logging retention window (badge-controlled doors/restricted rooms; evidence capture process) | Service Delivery Manager | Department | 32h | £15,000 |
| Complete system/design/configuration documentation and privacy/risk assessment for identity-to-output linking; produce audit-ready evidence pack template | Data Protection Officer | Enterprise | 24h | — |

**Total Estimated Effort:** 336h  
**Total Estimated Cost:** £45,000

###### Actions Required for Compliance

- [ ] Create and keep an up-to-date list of in-scope output devices (printers and photocopiers) that require identity-linked release.
- [ ] Set up secure “hold and release” for each in-scope printer and photocopier, and configure it so that releasing a held print requires the user to successfully authenticate on the device.
- [ ] Link device sign-in to the organisation’s identity provider so that each signed-in user is matched to a single, unique person identity.
- [ ] Set up print management rules so any sensitive print job is always sent to the secure/held queue, with no option to bypass this for outputs that fall within scope.
- [ ] Set up and centralise audit logs for release and denial events, including the user identity, device ID, job ID and job name, and the date and time; then send the logs to security information and event management (SIEM).
- [ ] Put physical access controls in place for device locations, and keep records of who accessed them for as long as the organisation keeps its logs.
- [ ] Document the design and configuration, and complete the privacy planning and risk assessment for linking identity to output.


---

### PE-6 — Monitoring Physical Access (Control)

This expectation is about closely monitoring who physically enters the building where your system is kept. This helps identify suspicious activity early and respond properly. Without this, someone could enter unnoticed, access restricted areas at the wrong time, repeatedly go into areas they should not, stay in an area for unusually long periods, move through doors in an unusual order, or continue after a security alarm—leaving the organisation vulnerable to theft, disruption, or unauthorised access.

To meet this expectation, the organisation must monitor physical entry across the whole site, including areas that are open to the public, using practical measures such as security guards, cameras, or sensors. It must review physical access records every day, and immediately investigate any access outside normal working hours, repeated access to unusual areas, unusually long access, access through doors in the wrong order, or any access after an access-control alarm.

The organisation must record what it found and coordinate the results of its reviews and investigations with its incident response capability.

##### Daily review and event-triggered investigation of physical access logs

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define physical access monitoring scope: “access area” inventory for all facility areas (incl. publicly accessible areas) and mapping of each area to door/reader/camera/sensor sources | Compliance Manager | Enterprise | 24h | — |
| Define suspicious trigger rules and evidence requirements: out-of-hours, repeated unusual-area access, unusually long access, out-of-sequence access, and access after access-control alarm; produce rule specification and audit evidence checklist | Security Engineer | Enterprise | 32h | — |
| Configure auditable, time-synchronised, tamper-evident log fields across access-control and supporting video/sensor systems (timestamp normalisation, door/zone mapping, subject identifier, event type, alarm linkage) | Infrastructure Lead | Enterprise | 56h | £8,000 |
| Implement log ingestion into SIEM/monitoring platform with normalised schema and retention alignment; validate end-to-end integrity (source-to-SIEM correlation, clock drift handling) | DevOps Lead | Enterprise | 48h | £12,000 |
| Build automated daily exception reporting (scheduled job + queries) that generates exception reports for defined triggers and assigns to named reviewers; include audit trail of report generation and reviewer assignment | SIEM/Monitoring Engineer | Enterprise | 40h | £6,000 |
| Implement immediate investigation workflow for triggers: auto-create incident/alert records, route to physical security/SOC triage queue, attach evidence pointers (door event details + relevant video clip references), and confirm initiation via incident response process | Operations Lead | Enterprise | 40h | £10,000 |
| Operationalise and evidence: define RACI and runbooks for daily review and triage, implement review outcome logging/closure fields, and conduct tabletop + pilot for audit-ready evidence capture | Project Manager | Enterprise | 32h | — |

**Total Estimated Effort:** 312h  
**Total Estimated Cost:** £36,000

###### Actions Required for Compliance

- [ ] Create an inventory of all publicly accessible areas, and for each area, record which physical monitoring log sources cover it.
- [ ] Set up access controls and any sensor or video systems to produce time-matched, traceable records of physical entry, linked to the relevant door or area and any related alarms.
- [ ] Set up daily scheduled checks that produce exception reports for the agreed suspicious triggers, and send them to specific named reviewers.
- [ ] Set up real-time alerts so that, whenever any agreed trigger happens, the system automatically creates a case for triage and investigation.
- [ ] Add evidence links to every alert or incident record (for example, door event details and references to the relevant video clips).
- [ ] Record the results of every daily review and every investigation that is triggered, and link confirmed incidents to the incident response process.


---

#### PE-6.1 — Intrusion Alarms and Surveillance Equipment (Enhancement)

This requirement is about making sure that if someone tries to enter the area where your system is kept, you are alerted straight away and can see what happened. If there were no physical alarms and cameras, unauthorised entry could go unnoticed, giving criminals or other wrongdoers time to tamper with equipment, steal information, or cause disruption.

To meet this expectation, the organisation must clearly decide which parts of the site and which entry points are covered. It must then use physical intrusion alarms (for example, alarms on doors, movement detectors, or glass-break sensors) and surveillance cameras in key locations to monitor access attempts and trigger action by security staff.

The organisation must keep records of alarm events and camera monitoring activity, review them regularly, and document the procedures, the people responsible, and how the alarm and camera systems work. It must also have privacy documentation explaining what is monitored, why it is monitored, and how privacy is protected. Finally, it must ensure that clear responsibilities are in place for responding to incidents when monitoring suggests a possible unauthorised access event.

##### Alarm + CCTV coverage with correlated alerts and evidence workflow

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Produce approved zone/entry-point coverage map (server room approach routes, doors, loading bays, corridors) including sensor and camera assignments | Compliance Manager | Enterprise | 24h | — |
| Define alarm event taxonomy and mapping to named zones/entry points (sensor types, arming/response states, operating hours, acknowledgement states) | Security Engineer | Enterprise | 16h | — |
| Deploy and verify intrusion sensors for covered entry points (door contacts, motion and/or glass-break as required) and confirm correct event generation to the monitoring console | Infrastructure Lead | Department | 40h | £6,000 |
| Deploy and verify CCTV coverage for each covered entry point (camera placement, stable identifiers/labels, live view and recorded playback, time synchronisation) | Infrastructure Lead | Department | 48h | £18,000 |
| Configure correlated alarm-to-evidence workflow (on intrusion event, present relevant camera(s) and evidence time window; define clip capture rules and retention alignment) | Operations Lead | Department | 32h | £3,500 |
| Implement documented security response SOP for correlated alarms (who is alerted, checks to perform, evidence capture steps, escalation/incident declaration criteria, and closure/outcome recording) | Compliance Manager | Enterprise | 20h | — |
| Establish auditable recordkeeping and review cadence (event log fields, reviewer identity, daily/weekly review process, evidence retention/access controls, audit pack template) | Data Protection Officer | Enterprise | 24h | — |
| Create and approve privacy governance documentation for surveillance/monitoring (purpose, scope, minimisation, retention, access controls, and compliance with applicable privacy requirements) | Data Protection Officer | Enterprise | 16h | — |

**Total Estimated Effort:** 240h  
**Total Estimated Cost:** £27,500

###### Actions Required for Compliance

- [ ] Create and get approval for a coverage map showing which facility areas (zones and entry points) the system is installed in.
- [ ] Check that intrusion sensors (door contacts, motion sensors, and glass-break sensors where applicable) are installed, correctly linked to the relevant areas (zones), and configured to send alerts (events).
- [ ] Check that CCTV covers every covered entry point and approach route, using consistent camera identifiers and dependable recording.
- [ ] Set up the monitoring process so that every intrusion alarm is matched to the correct camera(s) and the correct time window for the supporting evidence.
- [ ] Create a standard operating procedure (SOP) that sets out who should receive alerts, how alerts must be checked, when issues must be escalated, and what proof (evidence) must be recorded.
- [ ] Set up how long event and monitoring records are kept, and ensure they are reviewed by named people on a regular schedule.
- [ ] Maintain privacy documentation that explains what is monitored, why it is monitored, and how privacy is protected, including how long information is kept and who can access it.


---

#### PE-6.2 — Automated Intrusion Recognition and Responses (Enhancement)

This requirement is about automatically spotting common signs of unauthorised break-ins and immediately taking sensible protective action, without waiting for someone to notice. It matters because attackers may try to guess or reuse login details, spread harmful software or lock your systems for ransom, attack web services, try to gain higher access rights, or move from one system to another—often faster than people can respond—leading to service disruption, data loss, and financial harm.

To meet this expectation, the organisation must set up automated detection to recognise credential stuffing, malware or ransomware activity, web application attacks such as SQL injection or cross-site scripting, attempts to increase access rights, and suspicious movement between systems. It must then automatically carry out the matching response actions: isolate the affected device or network area, block the offending internet addresses or domains, disable any compromised accounts, raise an incident ticket to the security operations centre, and notify the incident response lead. This should be done using approved automated mechanisms such as automated alert analysis, automated device containment, intrusion alerts, guided response workflows, and email or text messages to on-call responders.

The organisation must document the types of intrusion and the response actions, define responsibilities and processes (including where physical access monitoring is involved), keep the required plans and records, and retain audit evidence showing what was detected and what actions were taken.

##### SIEM-to-SOAR automated intrusion recognition and response

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Define intrusion taxonomy (5 classes) and detection-to-response mapping (inputs, enrichment fields, confidence/time-window requirements, required response actions) | Cyber Security Lead | Enterprise | 24h | — |
| Implement SIEM detection-as-code correlation rules for each intrusion class (structured payload schema consumable by SOAR; correlation identifiers included) | Security Engineer | Department | 56h | — |
| Build/extend SIEM→SOAR integration layer (event normalisation, routing logic, enrichment lookups for asset/user/source, idempotency/deduplication) | Platform Engineer | Enterprise | 40h | — |
| Develop SOAR playbooks per intrusion class (isolate host/segment, block IP/domain, disable compromised accounts via approved IAM APIs, create SOC ticket, notify incident response lead) | DevOps Lead | Enterprise | 72h | — |
| Implement automation guardrails (blast-radius limits, allow/deny lists, confidence thresholds, rate limiting, restricted-action escalation paths, dry-run/simulation mode) | Security Engineer | Enterprise | 48h | — |
| Implement end-to-end auditability and evidence capture (detection ID → playbook run ID → actions → SOC ticket ID → notification receipt; immutable logging/retention alignment) | Compliance Manager | Enterprise | 32h | — |
| Integration testing, tabletop exercises, and controlled production rollout (test cases per class, failure-mode testing, rollback plan, change management release) | Project Manager | Enterprise | 40h | £12,000 |
| Total Estimated Effort |  |  | **312h** |  |
| Total Estimated Cost |  |  |  | **£12,000** |

###### Actions Required for Compliance

- [ ] Define an intrusion classification scheme in the security information and event management (SIEM) and security orchestration, automation and response (SOAR) layer for the five intrusion types defined by the organisation, including the required enrichment fields.
- [ ] Set up and version security information and event management (SIEM) correlation rules for each type of intrusion to produce structured events that can be used by security orchestration, automation and response (SOAR).
- [ ] Create security orchestration, automation and response (SOAR) playbooks that link each type of intrusion to the organisation’s agreed response actions: isolate, block, disable accounts, raise a security operations centre (SOC) ticket, and notify the incident response lead.
- [ ] Integrate security orchestration, automation and response (SOAR) with endpoint detection and response (EDR) containment, firewall and web application firewall (WAF) or secure domain name system (DNS) blocking, and identity and access management (IAM) and identity governance and administration (IGA) account disablement application programming interfaces (APIs), using blast-radius limits and confidence checks to prevent unintended impact
- [ ] Set up integrations between security monitoring and response tools—security information and event management (SIEM), security orchestration, automation and response (SOAR), endpoint detection and response (EDR), and identity and access management (IAM)—so they capture complete audit evidence that links each detection reference to every response action taken and the final result of any notifications.
- [ ] Run tabletop exercises and technical checks for each type of intrusion to confirm that automated alerts start immediately (without waiting for manual action) and that the expected security operations centre (SOC) ticket and notifications are generated.


---

#### PE-6.3 — Video Surveillance (Enhancement)

This requirement is about using cameras to create a clear record of who enters and moves around the most sensitive areas of your site. This helps you spot suspicious activity and investigate it later. Without this, unauthorised people could access data centre entrances, server rooms, or the site perimeter, and you may not notice unusual behaviour in time or be able to prove what happened afterwards.

To meet this requirement, the organisation must install video surveillance that covers:
- data centre entrances
- server rooms
- perimeter access points

The organisation must then regularly review the footage for alerts and unusual behaviour:
- review it every day when there are alerts or anomalies
- otherwise, review it at least once a week

The organisation must also keep the recorded footage for 90 days, and be able to demonstrate that:
- the cameras are positioned correctly
- reviews are carried out at the required frequency
- recordings can be retrieved within the 90-day period

##### VMS video coverage, 90-day retention and auditable review workflow

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Create/refresh camera coverage register covering data centre entrances, server rooms, and perimeter access points (camera IDs, fields of view, recording profiles, evidence of “active coverage”) | Physical Security Lead | Enterprise | 16h | — |
| Configure VMS camera mapping and recording profiles to ensure every required operational area is covered; validate coverage in test mode | Infrastructure/VMS Engineer | Enterprise | 24h | — |
| Configure VMS retention to 90 days for relevant streams; enable tamper-evident/immutable storage features where supported; capture configuration evidence (screenshots/exported config) | Infrastructure/VMS Engineer | Enterprise | 20h | £3,000 |
| Implement RBAC and authentication integration with enterprise identity provider (MFA/conditional access as applicable); define roles for reviewer/exporter/administrator/auditor and enforce least privilege | IAM Team | Enterprise | 32h | — |
| Configure and operationalise review workflow: daily review queue for alerts/anomalies, weekly review tasks for non-event periods; implement structured review outcome fields and link to ticket/evidence reference | Cyber Security Lead | Enterprise | 28h | — |
| Implement audit logging and evidence retention: ensure VMS logs capture logins, viewing sessions, export/download actions, and administrative changes; verify logs are retained and accessible for audit | Security Engineer | Enterprise | 20h | — |
| Execute retrieval tests to prove retrieval within 90 days (monthly run): retrieve sample from exactly 90 days prior, document success/exceptions, and store results in controlled repository | Compliance Manager | Enterprise | 24h | — |
| Compile audit-ready evidence pack (coverage register, VMS retention configuration evidence, review logs/workflow outputs, access control model, retrieval test results) and complete compliance sign-off | Compliance Manager | Enterprise | 16h | — |

**Total Estimated Effort:** 200h  
**Total Estimated Cost:** £3,000

###### Actions Required for Compliance

- [ ] Create a camera coverage register that links each data centre entrance, server room, and perimeter access point to the relevant video management system (VMS) camera ID and its field of view.
- [ ] Set the video management system (VMS) retention policy to keep recordings for 90 days for all required camera streams.
- [ ] Set up daily review queues that automatically collect alert and unusual-activity items, and schedule a weekly review for the remaining cameras and areas.
- [ ] Apply least-privilege role-based access control (RBAC) in the video management system (VMS) for the roles (reviewer, exporter, administrator, auditor) and link sign-in to the organisation’s identity provider (IdP).
- [ ] Turn on and keep audit logs so you can review viewing sessions, any export or download actions, and any administrative changes to camera settings or retention settings.
- [ ] Run and record regular retrieval tests to pull video footage from exactly 90 days ago, and keep evidence showing the results.


---

#### PE-6.4 — Monitoring Physical Access to Systems (Enhancement)

This requirement is about keeping a detailed record of who physically enters the specific rooms where key equipment is kept, such as server rooms, media storage areas, and communications centres. This goes beyond general building security.

Without this extra, room-by-room monitoring, unauthorised people could access critical systems or sensitive storage without being detected. It could also allow legitimate access to be misused without anyone noticing, increasing the risk of disruption, data loss, or misuse.

To meet this expectation, the organisation must:
- identify and document these key equipment areas
- set clear written procedures for monitoring access to the systems in those areas
- assign named staff to carry out the monitoring, involving information security and privacy roles where appropriate
- use approved access methods (such as access badges or keys)
- keep reliable access records showing who entered and when
- retain those records for review
- document the approach in its system security and privacy planning, including privacy impact and risk assessments

##### Area-specific physical access monitoring for system-concentration rooms

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Confirm monitored scope: produce an area-to-door/portal mapping for each system-concentration area (server rooms, media storage, communications centres) including door identifiers and access control point details | Physical Security Lead | Enterprise | 24h | — |
| Define area-level logging requirements: specify required event fields (timestamp, credential identifier, event type, area/door identifier), normalisation rules, and acceptance test cases | Compliance Manager | Enterprise | 16h | — |
| Configure PACS/physical access control points for area-level event capture: enable/adjust event types and ensure credential identifiers and door/area identifiers are emitted | Infrastructure Lead | Enterprise | 40h | — |
| Implement secure log export pipeline to central logging destination (SIEM or dedicated physical security log store), including restricted write access and tamper-evident storage where available | DevOps Lead | Enterprise | 32h | £6,000 |
| Implement time synchronisation and event integrity controls for exported logs (e.g., NTP alignment, integrity checks, and validation of log completeness) | Security Engineer | Enterprise | 16h | — |
| Create audit-ready monitoring and exception handling procedure: documented workflow, named roles, escalation paths, and evidence retrieval by area and time (including after-hours/denied/repeated attempts) | SOC / Security Operations Lead | Enterprise | 24h | — |
| Privacy-by-design assurance for any supporting video/analytics: complete/confirm privacy impact/risk assessment coverage and document outcomes in system security/privacy planning artefacts | Data Protection Officer | Enterprise | 16h | £3,000 |
| Run end-to-end testing and go-live readiness: validate that each area produces correct logs, SIEM ingestion works, retention/evidence retrieval meets requirements, and produce sign-off pack for audit | Project Manager | Enterprise | 24h | — |

**Total Estimated Effort:** 192h  
**Total Estimated Cost:** £9,000

###### Actions Required for Compliance

- [ ] Create an official map that links each system concentration area (server rooms, media storage areas, communications centres) to the specific picture archiving and communication system (PACS) doors or entry portals that control access.
- [ ] Set up the physical access control points (PACS) to record: the date and time, the credential identifier, the type of event (entry, exit, denied, or door opened), and the area or door identifier.
- [ ] Export and centralise area-level physical access events into the organisation’s secure logging and security information and event management (SIEM) system, with restricted access and tamper-evident protections where available.
- [ ] Define and document an exception-handling monitoring process for the monitored areas, including who reviews exceptions, how often reviews happen, the steps to investigate, and how issues are escalated.
- [ ] Set up correlation rules to connect physical access exceptions in monitored areas with existing intrusion detection and incident reporting workflows.
- [ ] Check that logs are kept for the required length of time and that they can be retrieved for audits by department and date range, and test that the evidence can be produced for review.
- [ ] Complete and record a privacy impact and privacy risk assessment for any additional monitoring data sources used to support system-area monitoring.


---

### PE-8 — Visitor Access Records (Control)

This requirement is about keeping a clear, time-stamped record of who enters the building where your systems are kept, and ensuring those records are checked and followed up. Without this, the organisation could miss unauthorised visitors, fail to notice incorrect or unexpected entries, or continue allowing access that is no longer needed—raising the risk of theft, disruption, or other harm to critical operations.

To meet this expectation, the organisation must keep complete visitor access records for 365 days. These records must include details such as who visited, who they were visiting, why they came, what identification they provided, when they entered and left, and their signature. Every 90 days, the organisation must review these records to confirm that each visitor’s access is still up to date and still needed for business purposes.

Any unusual or unexpected findings must be reported to the Security Operations Centre lead and the facility security manager. Records are not required for areas that are publicly accessible.

##### Visitor access records with 365-day retention and 90-day reviews

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define visitor record data model and check-in workflow rules (restricted areas only; required fields; mapping of “individuals visited”; validation rules for time order and mandatory attributes) | System Design Authority | Enterprise | 24h | — |
| Implement check-in capture and signature/ID form ingestion (UI/workflow changes; identity/host linkage; ensure publicly accessible areas do not generate records) | Software Lead | Enterprise | 56h | — |
| Implement tamper-evident, append-only storage and time-stamped entry/exit event logging (including record identifiers for audit and downstream review packs) | Platform Engineer | Enterprise | 64h | £18,000 |
| Configure 365-day retention with legal hold/exception handling (lifecycle policies, deletion safeguards, and audit logging of retention actions) | Compliance Manager | Enterprise | 32h | £6,000 |
| Build automated 90-day review workflow (scheduled job; review pack generation; anomaly rules: missing/invalid fields, time inconsistencies, inactive/non-existent hosts/visited persons, purpose/host mapping misalignment) | DevOps Lead | Enterprise | 48h | — |
| Integrate anomaly escalation to case management and notifications to SOC lead and facility security manager (evidence bundle: record IDs, timestamps, missing fields, host mapping changes) | Security Engineer | Enterprise | 40h | £4,500 |
| Implement review accountability and audit evidence (store reviewer identity, review date, disposition; reporting dashboards/export for audits; test evidence completeness) | Quality Assurance Lead | Enterprise | 24h | — |

**Total Estimated Effort:** 288h  
**Total Estimated Cost:** £28,500

###### Actions Required for Compliance

- [ ] Set up the visitor sign-in process to collect all required PE-8 details and signatures for access to restricted areas only.
- [ ] Define and enforce two entry types—“publicly accessible” and “restricted facility”—so that people entering public areas do not create visitor records.
- [ ] Set up tamper-evident, auditable storage for visitor access records, recording time-stamped entry and departure events.
- [ ] Set retention controls to keep visitor access records for 365 days, using organisational legal-hold handling if applicable.
- [ ] Set up and run an automated 90-day review process that checks for missing information, time-related inconsistencies, and changes in whether the host and the visited person are still relevant.
- [ ] Set up an anomaly escalation process that alerts the security operations centre (SOC) lead and the facility security manager, including the supporting evidence and the case reference identifiers.


---

#### PE-8.1 — Automated Records Maintenance and Review (Enhancement)

This requirement is about ensuring visitor access records are captured automatically, kept up to date, and reviewed regularly, so that only the right people have access for the right reasons. Without this, a visitor’s access could continue after it should have ended, sponsor approval could be missed, or unusual access could go unnoticed—raising the risk of unauthorised entry or internal incidents.

The organisation must automatically collect visitor badge and entry events from its on-site physical entry system and store them in a records database, including the visitor’s identity, sponsor, site or location, and the date and time. It must use built-in checks to make sure the information is reliable. It must also link these visitor records to its access authorisation records so staff can review them properly.

At scheduled intervals, automated checks must highlight expired permissions, permissions that are still active, missing sponsor approvals, and unusual access patterns for human review. The organisation must provide clear outputs, documented procedures, named responsibilities, and evidence that these reviews are carried out and records are kept.

##### PACS-to-visitor records ingestion with scheduled automated review

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define PACS-to-IAM identity mapping and ingestion scope (authoritative matching key, required fields, cadence, and review rules aligned to pe-8.1_prm_1) | Compliance Manager | Enterprise | 24h | — |
| Design and implement visitor access records database schema (visitor identity, sponsor, site/location, event timestamps, ingestion batch metadata, audit fields) | System Design Authority | Enterprise | 40h | — |
| Build PACS ingestion integration (API/pull or event streaming connector), including secure connectivity, retry handling, and idempotent writes to the visitor records database | Platform Engineer | Enterprise | 72h | £6,000 |
| Implement ingestion integrity checks and tamper-evident/audit logging (schema completeness, timestamp sanity, sponsor existence/approval validation, ingestion success/failure evidence) | Security Engineer | Enterprise | 56h | — |
| Integrate review engine with IAM/authorisation and sponsor approval data (read-only interfaces, data mapping, and access controls for review queries) | Infrastructure Lead | Enterprise | 40h | — |
| Implement scheduled automated review queries and flagging logic (expired, still-active, missing sponsor approvals, anomalous access patterns) and publish results to a review queue/case view | Software Lead | Enterprise | 64h | £3,000 |
| Implement review evidence capture and outcome workflow (review timestamp, reviewer identity, disposition, corrective action references; retention aligned to policy) | Operations Lead | Enterprise | 32h | — |

| Total Estimated Effort | 328h |  |
| Total Estimated Cost |  | £9,000 |

###### Actions Required for Compliance

- [ ] Define the official mapping between the picture archiving and communication system (PACS) and identity and access management (IAM) for visitor records, and apply rules to ensure each mapping is unique.
- [ ] Set up a process to bring visitor records from the PACS system into an auditable database, storing the visitor’s identity, sponsor, site or location, and the relevant dates and times (timestamps).
- [ ] Set up automated checks during data intake to confirm the information is complete, the timestamps are reasonable, and the sponsor details are valid and approved.
- [ ] Integrate the review engine with identity and access management (IAM) and authorisation status, and with sponsor approval information, using read-only interfaces.
- [ ] Run scheduled automated checks to identify expired items, items that are still active, missing sponsor approvals, and unusual access patterns.
- [ ] Set up a review queue (or case view) and record, for each flagged item, who reviewed it, the date and time of the review, the outcome (disposition), and any corrective actions taken.


---

#### PE-8.3 — Limit Personally Identifiable Information Elements (Enhancement)

This requirement is about making sure visitor records do not include more personal information than is necessary.

It matters because if visitor access records contain unnecessary details—such as home addresses, personal phone numbers, personal email addresses, dates of birth, or government-issued identity numbers—then any mistake, unauthorised access, or data leak could cause greater harm.

To meet this expectation, the organisation must first use its privacy risk assessment to identify exactly which information is needed for visitor access records. It must then store only the following items:
- full name  
- home address  
- personal phone number  
- personal email address  
- date of birth  
- government-issued identity numbers  

The organisation must ensure no other personal details are added. It must also be able to demonstrate this by checking the records and confirming how the fields are defined, so it is clear that only the permitted items are included.

##### Allowlist-only PII fields in visitor access records

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Confirm permitted PII allowlist for visitor access records (full name, home address, personal phone, personal email, date of birth, government-issued ID numbers) and publish as single source of truth (versioned) | Data Protection Officer | Enterprise | 8h | — |
| Implement capture-layer enforcement: update web/mobile form, kiosk UI, and front-desk/internal app to only present permitted fields; remove non-permitted inputs and disable free-text capture for additional PII | Software Lead | Enterprise | 40h | — |
| Implement API/integration-layer fail-closed validation: validate inbound payload keys/fields against allowlist; reject requests containing non-permitted PII; ensure upstream mappings only populate permitted fields | Software Lead | Enterprise | 48h | — |
| Implement data model/storage-layer enforcement: adjust visitor access record schema/ORM/entities so only permitted PII attributes are persisted as PII; ensure any other data is stored in non-PII categories or not persisted | Platform Engineer | Enterprise | 40h | — |
| Add automated verification: scheduled audit job to scan visitor access records for (a) only permitted PII fields and (b) absence of non-permitted PII attributes; persist audit outputs for review | Operations Lead | Enterprise | 32h | — |
| Integrate audit evidence into governance: define reporting cadence, retention period, and evidence format; ensure audit outputs are accessible for compliance review | Compliance Manager | Enterprise | 16h | — |
| Operationalise change control: implement version-controlled configuration for the allowlist and validation rules; ensure approvals are linked to privacy risk assessment updates and changes are deployed via release pipeline | Project Manager | Enterprise | 24h | — |

**Total Estimated Effort:** 208h  
**Total Estimated Cost:** £0

###### Actions Required for Compliance

- [ ] Create and document the visitor-record personal data (PII) “allowed list” exactly as defined in **pe-08.03_odp**, including: full name, home address, personal phone number, personal email address, date of birth, and government-issued identification numbers.
- [ ] Remove any personal data (PII) fields that are not allowed from all visitor data capture screens (web, mobile, kiosk, and front desk) and turn off any free-text entry that could collect additional personal data (PII).
- [ ] Set up checks for incoming application programming interface (API) requests and their data (payloads) to reject any visitor-record submissions that include personal information (PII) fields that are not allowed (fail closed).
- [ ] Limit the visitor access record data so it only includes approved personal information (PII) fields/columns, or ensure any unapproved data is not saved as personal information (PII) in visitor access records.
- [ ] Update all integrations and mappings that write visitor access records to populate only permitted personal information (PII) fields, and remove, or replace with tokens, everything else.
- [ ] Set up an automated audit to check visitor access records contain only the permitted personal information fields, and save the results as evidence for compliance review.
- [ ] Manage the allowlist and validation rules as version-controlled configuration, with approval from the privacy officer for any changes.


---

### PE-9 — Power Equipment and Cabling (Control)

This requirement is about making sure the power supplies and the cables that keep the system running are physically protected against damage or destruction. If power equipment or cabling is knocked, interfered with, exposed to the weather, or otherwise harmed, the system could fail, shut down unexpectedly, or become unreliable—causing disruption for the organisation and potentially putting critical services at risk.

To meet this expectation, the organisation must clearly document how it will protect all system power equipment and power cabling, both inside its own buildings (such as offices and data centres) and outside them (such as generators and their external cabling). It must also cover power sources for self-contained or deployable components, such as vehicles and satellites.

The organisation must create step-by-step procedures for protecting the equipment and cabling, list every internal and external location where this equipment and cabling are stored or routed, apply the appropriate physical protections at each location, name specific people responsible for these protections, ensure they understand their responsibilities, involve staff with information security responsibilities, and keep evidence showing that the protections have been defined and put in place.

##### Power protection playbooks and evidence for all power equipment/cabling

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Create and approve a power asset & cabling location register (internal, external, deployable) with asset identifiers, physical location identifiers, and ownership/maintenance references | Infrastructure Lead | Enterprise | 24h | — |
| Perform risk-based “power protection approach” definition, explicitly distinguishing internal vs external vs deployable environments and specifying protection types (physical, routing/containment, environmental, tamper deterrence, foreseeable hazards) | System Design Authority | Enterprise | 16h | — |
| Draft the “Power equipment playbook” (UPS/PDUs/batteries/transfer switches/generators/deployable power sources) including inspection steps, securing actions, and suspected-damage response workflow | Compliance Manager | Enterprise | 20h | — |
| Draft the “Power cabling playbook” (internal routes/trays/conduits, external runs, deployable cabling) including inspection steps, secure routing/containment requirements, and suspected-damage response workflow | Security Engineer | Enterprise | 20h | — |
| Tailor both playbooks per location type and produce location-specific checklists mapped to register entries (including evidence requirements such as photos, readings, and corrective action fields) | Project Manager | Enterprise | 24h | — |
| Implement evidence capture in the work-order/CMMS workflow: configure checklist templates, enforce mandatory evidence fields, and link work orders to register entries and corrective actions | DevOps Lead | Enterprise | 32h | £3,000 |
| Update the system security plan to name accountable roles, responsibilities, escalation/incident handling for suspected tampering/damage, and references to both playbooks and evidence expectations | Data Protection Officer | Enterprise | 12h | — |
| Deliver training and competency sign-off for accountable roles (facilities/data centre operations/field engineering) including walkthroughs, escalation criteria, and how to record auditable evidence | Service Delivery Manager | Enterprise | 16h | £2,000 |

**Total Estimated Effort:** 164h  
**Total Estimated Cost:** £5,000

###### Actions Required for Compliance

- [ ] Create and keep a complete list (register) of all places—inside the organisation, outside the organisation, and places where equipment is deployed—where the system’s power equipment and power cables are stored or routed.
- [ ] Define a risk-based approach to power protection that distinguishes between internal, external, and deployable environments.
- [ ] Publish location-specific playbooks for power equipment and power cabling, with step-by-step instructions for inspection, securing, and escalation procedures.
- [ ] Set up the computerised maintenance management system (CMMS) and work-order process so that inspections and relevant changes cannot be completed unless a checklist is finished and supporting evidence is recorded (including photos where appropriate).
- [ ] Update the system security plan to include the power protection approach and to name the responsible accountable roles for each type of location.
- [ ] Train the accountable operational teams and information security stakeholders on the incident playbooks, what evidence is required, and when and how to escalate issues.


---

#### PE-9.1 — Redundant Cabling (Enhancement)

This requirement is about making sure your power supply has a backup route that is physically kept well away from the main route. It addresses the real-world risk that if one power cable route is cut, damaged, or fails, the backup route could also be affected if the two routes are too close together. This could cause equipment to lose power and operations to stop.

To meet this expectation, the organisation must install at least two separate power cable routes for backup (redundancy) and keep those routes at least 2 metres apart along their entire route. This reduces the chance that damage to one route will also harm the other.

The organisation should:
- document how the separated, backup cabling is designed and installed
- have clear procedures for protecting power cables and maintaining the 2-metre separation
- assign named staff responsibility for protecting the cabling
- include this approach in its planning documents

Any facilities that house the power equipment must also support and maintain the required separation.

##### Independent redundant power routes with ≥2m physical separation

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Confirm scope of “critical power path pairs” (A/B) and identify affected power sources, PDUs/UPS outputs, and critical loads; produce a route list and containment zones to be assessed | Compliance Manager | Enterprise | 8h | — |
| Produce/refresh two-route power cabling design drawings (A/B) with independent containment/tray/conduit routing and clearly marked route identifiers and expected closest-approach locations | System Design Authority | Enterprise | 24h | — |
| Define the separation measurement method and acceptance criteria for ≥2m closest-point verification (including calibration/measurement approach and evidence requirements) and issue as an installation/inspection checklist | Compliance Manager | Enterprise | 12h | — |
| Execute site installation verification: measure minimum closest-point separation between redundant routes at each identified location; record measured distances and capture photo evidence with route identifiers | Operations Lead | Department | 32h | £1,500 |
| Update as-built drawings and inspection/acceptance records to include: measured minimum separation (≥2m), route A/B identifiers, containment identifiers, and references to photo evidence | Infrastructure Lead | Department | 16h | — |
| Implement change control gate for power cabling: require separation re-check and evidence update for any route modification/addition/reroute affecting A/B paths; update relevant change templates/work instructions | Project Manager | Enterprise | 16h | — |
| Perform internal compliance review and audit readiness check (traceability from design → measurements → as-built evidence) and remediate any non-conformities (e.g., reroute/adjust containment to restore ≥2m) | Cyber Security Lead | Enterprise | 20h | £2,500 |

**Total Estimated Effort:** 128h  
**Total Estimated Cost:** £4,000

###### Actions Required for Compliance

- [ ] Create a two-route (A/B) redundant power cable layout, with each critical power load kept in its own separate containment area (separate cable trays, conduits, and zones).
- [ ] Mark the expected points of closest approach on the route drawings for the redundant cabling paths.
- [ ] Measure and record the minimum physical distance between the A and B routes during installation, and make sure it is at least 2 metres.
- [ ] Take and save photo evidence at the measurement point, and store it together with the as-built drawings and the inspection and acceptance records.
- [ ] Update the system security planning documentation to reference the redundant power design and the requirement for at least 2 metres of separation.
- [ ] Implement a change-control checkpoint that requires re-checking separation and updating supporting evidence for any changes to power cabling.


---

#### PE-9.2 — Automatic Voltage Controls (Enhancement)

This requirement is about keeping the electricity supply stable for the most important equipment that handles Secret and Confidential information. It does this by using automatic devices that continuously check the incoming power and automatically correct or stabilise it when it starts to vary. Without this, even small power problems can damage equipment, cause outages, or result in data loss and service disruption—especially for mission-critical servers, network switches and routers, storage systems, and security appliances.

To meet this requirement, the organisation must keep a documented list of the specific components that need automatic voltage monitoring and stabilisation. It must then ensure the correct equipment is installed for each component and configured to monitor the power and respond automatically.

The organisation must also document how the voltage is monitored and what actions are taken when power limits are exceeded. It must assign named individuals responsible for environmental protection and information security, and record the equipment details and settings in the relevant plans and procedures. This provides clear evidence that the arrangements are in place and working as intended.

##### Automatic voltage control for critical loads with monitored thresholds

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Establish and maintain the authoritative **pe-09.02_odp critical-load list** (scope definition, asset inclusion criteria, and ownership) | Compliance Manager | Enterprise | 16h | — |
| Map each pe-09.02_odp asset to its **physical power path** (UPS/PDU → automatic voltage control device → load) and produce a validated mapping register | Infrastructure Lead | Enterprise | 24h | — |
| Define the **approved voltage threshold/limit profiles** (undervoltage/overvoltage, fault states) and control action expectations, aligned to organisational standards | Security Engineer | Enterprise | 16h | — |
| Select and document the **automatic voltage control device type per power path** (regulator vs conditioner vs stabiliser), including required monitoring/logging/alert interfaces and compatibility checks | System Design Authority | Enterprise | 20h | £6,000 |
| Configure each device with **enabled monitoring**, **automatic correction actions**, and **event/state logging**; export baseline configuration evidence | Operations Lead | Department | 32h | £0 |
| Integrate device alerts into the **enterprise monitoring/ITSM workflow** (severity mapping, routing, escalation, and ticket triggers) and validate alert delivery | DevOps Lead | Enterprise | 24h | £3,000 |
| Update **system security plan** and **physical/environmental protection documentation** with audit-ready evidence (component list, device identifiers, configuration profile/threshold references, monitoring destinations, responsibilities) | Data Protection Officer | Enterprise | 18h | — |
| Perform validation and periodic verification evidence capture (review logs/events, confirm alerts/tickets during controlled windows or vendor self-test, retain evidence pack) | Service Delivery Manager | Enterprise | 20h | — |

**Total Estimated Effort:** 190h  
**Total Estimated Cost:** £9,000

###### Actions Required for Compliance

- [ ] Define and get approval for the official inventory of pe-09.02_odp critical system components that require automatic voltage control.
- [ ] Create power-path diagrams showing how each **pe-09.02_odp** component connects to its **uninterruptible power supply (UPS)**, **power distribution unit (PDU)**, and **automatic voltage control device**.
- [ ] Procure automatic voltage control equipment (voltage regulator/conditioner/stabiliser) that includes monitoring, automatic correction, and event logging.
- [ ] Set the organisation-approved low-voltage and high-voltage limits, and turn on automatic voltage control actions for each device.
- [ ] Set up device alerts (for example, simple network management protocol (SNMP), system log (syslog), or an application programming interface (API)) to feed into the organisation’s monitoring and information technology service management (ITSM) process, with clear escalation steps.
- [ ] Update the system security plan and the physical and environmental protection documents to include device identifiers, configuration profiles, and where monitoring and alerts should be sent.
- [ ] Keep records by exporting the device settings and checking recent voltage-control logs and alerts to confirm the system is working effectively.


---

### PE-10 — Emergency Shutoff (Control)

This requirement ensures there is a clear, quick way to switch off power to the data centre’s server racks and the equipment that distributes that power if something seriously goes wrong. Without an emergency shutoff that works reliably and can be reached immediately, a fire, flood, electrical fault, or other urgent incident could spread damage, put people at risk, or cause major disruption that takes much longer to resolve.

The organisation must provide an emergency shutoff capability that can switch off power to the server racks and the related power distribution units. It must install emergency shutoff switches or devices at the entrance to every data hall electrical room and at the main power distribution unit control panel. Only authorised personnel must be able to activate them.

The organisation must also physically and procedurally protect these shutoff devices against unauthorised use. It must keep clear written instructions on when to use the shutoff and how to restore power safely, and ensure the responsible staff know the correct locations and steps.

##### Hardwired emergency shutoff for data hall racks/PDUs with access control

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Produce rack-to-PDU-to-breaker emergency shutoff scope mapping per data hall (including device-to-load assignment matrix) | System Design Authority | Enterprise | 24h | — |
| Design hardwired emergency shutoff circuit approach and interface requirements (schematics, protection/labeling standards, fail-safe behaviour) | Infrastructure Lead | Enterprise | 32h | — |
| Procure emergency shutoff devices, locked enclosures, keying/lock hardware, tamper-evident seals/sensors (as feasible), and labelling/signage materials | Operations Lead | Enterprise | 8h | £18,000 |
| Install hardwired emergency shutoff circuits and integrate into relevant power paths for mapped racks/PDUs (including electrical isolation verification) | Security Engineer | Department | 40h | £12,000 |
| Install emergency shutoff devices at each data hall electrical room entrance and at the main PDU control panel; ensure unobstructed access routes and consistent labelling | Infrastructure Lead | Enterprise | 24h | £6,000 |
| Implement access control for activation (locked enclosures, key register process, authorised key issuance/returns, tamper-evidence handling workflow) | Compliance Manager | Enterprise | 16h | £3,000 |
| Execute validation testing and produce audit-ready evidence pack (de-energisation scope tests per device, test records, photos of locations/labels, tamper checks, and restoration verification) | Operations Lead | Enterprise | 24h | — |
| Create and run emergency shutoff and safe restoration procedures (SOPs, tabletop walkthroughs, competency sign-off, periodic condition/access checks schedule) | Compliance Manager | Enterprise | 20h | — |

**Total Estimated Effort:** 208h  
**Total Estimated Cost:** £39,000

###### Actions Required for Compliance

- [ ] Create a link between each data hall emergency shutoff device and its rack, power distribution unit (PDU), and circuit breaker/feed.
- [ ] Design and install fixed (hardwired) power cut-off circuits that switch off power to the mapped server racks and the connected power distribution units (PDUs).
- [ ] Install emergency shut-off devices at the entrance to every data hall electrical room and at the main power distribution unit (PDU) control panel, with clear signage.
- [ ] Lock and protect each shut-off device using controlled key access and tamper-evident seals, with a key register kept under facilities and security control.
- [ ] Test and record that each power shut-off device correctly turns off the intended server racks and power distribution units (PDUs), and that it results in the expected safe operating state.
- [ ] Publish emergency shut-off and safe restart procedures, and run tabletop walkthroughs with the on-call operations team and facilities staff.


---

### PE-11 — Emergency Power (Control)

This requirement is about making sure your equipment does not lose power suddenly when the main electricity supply fails, giving you enough time to switch it off properly.

Without an uninterruptible power supply, a power cut could cause sudden stoppages, corrupted files, lost information, disruption to services, and even safety risks during an emergency.

To meet this expectation, the organisation must provide an uninterruptible power supply for the relevant systems. When the main power source is lost, it must automatically switch to emergency power within seconds and keep the system running long enough for an orderly shutdown.

The organisation must:
- document which equipment the uninterruptible power supply powers and how it supports the shutdown,
- keep this documentation up to date, and
- test the arrangement to confirm it works, recording the results.

The organisation must also have clear emergency power procedures that:
- name who is responsible, and
- explicitly instruct staff to use the uninterruptible power supply to carry out the orderly shutdown,
with these instructions reflected in the system’s plans.

##### UPS-backed orderly shutdown with automated trigger and evidence

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Produce UPS-to-system coverage mapping (UPS units → powered assets → orderly shutdown targets) including assumptions, exclusions, and dependencies | Infrastructure Lead | Enterprise | 16h | — |
| Perform UPS sizing and runtime determination (worst-case load model, growth margin, battery ageing assumptions) and define required shutdown completion runtime target | System Design Authority | Enterprise | 24h | — |
| Procure and install/commission appropriately sized UPS hardware (including batteries) for in-scope production infrastructure and validate transfer characteristics | Operations Lead | Enterprise | 8h | £18,000 |
| Configure UPS management/monitoring integration for automated trigger (e.g., SNMP/vendor API/agent) and define threshold logic (on-battery and/or estimated runtime) | Platform Engineer | Enterprise | 16h | £2,000 |
| Implement orderly shutdown orchestration invoked by UPS trigger (deterministic stop order for hypervisor/hosts, application services, dependent services, and safe power-down) | Software Lead | Enterprise | 32h | — |
| Create auditable evidence pack (coverage matrix, trigger thresholds, shutdown sequence logic, configuration snapshots, test logs template, retention approach) aligned to pe-11_odp | Compliance Manager | Enterprise | 16h | — |
| Execute and record UPS transfer/shutdown tests (simulate primary power loss, capture timestamps/indicators, confirm shutdown completion within runtime target, document deviations and corrective actions) | Quality Assurance Lead | Enterprise | 24h | — |
| Update emergency power procedures/runbooks and escalation/accountability (named responsibilities, what to check if shutdown does not complete, communications expectations) | Service Delivery Manager | Enterprise | 12h | — |

**Total Estimated Effort:** 148h  
**Total Estimated Cost:** £20,000

###### Actions Required for Compliance

- [ ] Create a matrix showing, for each in-scope system, which components are powered, to achieve **PE-11 ODP**.
- [ ] Calculate and set uninterruptible power supply (UPS) battery runtime targets that are longer than the worst-case measured orderly shutdown time, allowing for battery ageing and an additional load margin.
- [ ] Set up uninterruptible power supply (UPS) monitoring (using simple network management protocol (SNMP), the vendor’s application programming interface (API), or an agent) so it can detect when the UPS is running on battery or when the estimated remaining runtime drops below set limits, and then automatically shut down the connected system.
- [ ] Set up and test a controlled shutdown sequence when the uninterruptible power supply (UPS) triggers it: stop services in the correct order, stop new traffic and let existing work finish, then shut down the hosts.
- [ ] Run and record scheduled tests that simulate a primary power loss or power transfer, and show that the system finishes shutting down within the required time window.
- [ ] Publish and keep up to date emergency power procedures and escalation contact details, making sure they refer to the uninterruptible power supply (UPS) status indicators and the expected orderly shutdown steps.


---

#### PE-11.1 — Alternate Power Supply — Minimal Operational Capability (Enhancement)

This requirement is about making sure your key systems keep working during a long power cut. It requires a backup power supply that turns on automatically and keeps the system running at the minimum level you need.

Without this, an extended loss of main electricity could stop essential services, disrupt work, and prevent you from operating or responding when it matters most.

To meet this expectation, the organisation must:
- provide an alternative power supply for the in-scope system
- ensure it switches on automatically if the main power fails
- confirm it can sustain the minimum required operation for an extended outage

The organisation must also:
- document how the backup is set up and how it is used
- test it to prove it takes over automatically and can maintain minimum operation
- keep records of those tests
- include this approach in the system’s security planning

Named individuals must be responsible for emergency power actions. Emergency power procedures must be clear and easy to access, and staff with information security responsibilities must be involved in overseeing the arrangement.

##### Automatic UPS failover sized for minimum capability during outages

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define minimum operational capability (services/components) and extended outage target duration; produce an “Emergency Power Minimum Capability” scope document | Compliance Manager | Enterprise | 16h | — |
| Perform power/load assessment for the in-scope system (measured/estimated power draw per tier, peak vs steady-state, startup inrush, and runtime model) and produce sizing assumptions | Infrastructure Lead | Business Unit | 24h | — |
| Select and procure appropriately sized UPS and (if required) automatic transfer switching / secondary commercial/external power interface; confirm compatibility with existing rack/power distribution | Infrastructure Lead | Business Unit | 8h | £45,000 |
| Engineer UPS failover design for automatic activation (no manual start), including protected load mapping to the agreed minimum capability and configuration of UPS/ATS settings | System Design Authority | Department | 24h | £6,000 |
| Configure operational alarms and monitoring for outage mode (on UPS/external power, runtime remaining, approaching runtime end) and integrate alert routing to existing monitoring/incident channels | DevOps Lead | Department | 16h | £3,000 |
| Execute controlled failover and runtime verification tests; capture evidence (takeover behaviour, runtime remaining, services verified, timestamps, any deviations) and produce a test report | Operations Lead | Team | 24h | — |
| Update system security plan and emergency power procedures (what is powered, activation conditions, expected runtime basis, response if runtime is insufficient) and complete security review sign-off | Data Protection Officer | Enterprise | 16h | — |
| Assign named responsibilities for emergency power actions and ensure information security review covers security-relevant outage impacts (logging continuity, monitoring/alerting availability, incident response triggers) | Security Engineer | Enterprise | 8h | — |

**Total Estimated Effort:** 136h  
**Total Estimated Cost:** £54,000

###### Actions Required for Compliance

- [ ] Define the minimum operational capability the system must have, and the required maximum length of time it must be able to remain unavailable.
- [ ] Choose and size a backup power supply—either an uninterruptible power supply (UPS) and/or automatic switching to a secondary or external power source—to support the agreed minimum power requirement.
- [ ] Set up the backup power supply so it turns on automatically if the main power fails, in line with **PE-11.01_ODP**.
- [ ] Set up and connect uninterruptible power supply (UPS) and power-transfer status, including runtime alerts, to the operations monitoring system.
- [ ] Run failover and live-operation tests to confirm that automatic takeover works and that minimum required capability continues, and keep the test records as evidence.
- [ ] Update the system security plan and emergency power procedures to list which powered components are included, the conditions that trigger activation, and the expected runtime.
- [ ] Assign named responsibility for emergency power and complete a full information security review of any security impacts during outage mode.


---

#### PE-11.2 — Alternate Power Supply — Self-contained (Enhancement)

This requirement is about making sure your system can keep running if the main power fails. It requires a backup power source that starts automatically. Without this, a long power cut could switch off critical services, disrupt work, and potentially lead to loss of important operations because the system would have no reliable power to run on.

To meet this requirement, the organisation must provide an alternative power supply for the system that:
- turns on automatically when the main power source is lost,
- is self-contained and does not rely on power being provided from elsewhere, and
- can keep the system operating at full operational capability during an extended loss of the main power source.

The organisation must also document how the backup power works, what it powers, and how it supports full operation during a long outage. In addition, it must keep records showing that the backup has been tested to confirm it starts automatically and sustains full operation.

##### Self-contained auto-start generator/UPS for full operational capability

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define “full operational capability” load set and load-shedding plan (including explicit inclusion/exclusion list, priority tiers, and documented assumptions) | Compliance Manager | Enterprise | 24h | — |
| Perform power/runtime sizing for the defined load set (steady-state, peak/inrush, transfer losses, battery/generator ageing, temperature derating) and produce sizing calculations pack | Infrastructure Lead | Enterprise | 32h | — |
| Select and specify alternate power architecture (UPS capacity, generator sizing, transfer mechanism, fuel/battery strategy) and produce an auditable design specification | System Design Authority | Enterprise | 24h | £15,000 |
| Implement automatic activation and transfer logic (primary-loss detection, UPS transfer/ride-through, generator start sequencing, interlocks, alarms, and fail-safe behaviour) | DevOps Lead | Enterprise | 40h | £8,000 |
| Install/configure self-contained power components and integrate with monitoring/alerting (on-site fuel/battery provisioning, electrical integration, telemetry to monitoring stack) | Operations Lead | Enterprise | 56h | £120,000 |
| Execute staged acceptance testing and evidence capture (automatic start timing, voltage/frequency stability, runtime verification to extended-loss duration or validated equivalent, deviations and corrective actions) | Quality Assurance Lead | Enterprise | 40h | £5,000 |
| Produce final compliance pack for NIST PE-11(2) (design record, load list, sizing, activation logic, self-contained proof, test reports, maintenance/bypass constraints, and audit-ready traceability) | Data Protection Officer | Enterprise | 24h | — |

Total Estimated Effort: **240h**  
Total Estimated Cost: **£148,000**

###### Actions Required for Compliance

- [ ] Define and get approval for the system power-load settings needed to achieve “full operational capability” during an extended primary power outage.
- [ ] Measure power usage and work out the required uninterruptible power supply (UPS) and generator capacity, including how long they must run, for the approved set of loads.
- [ ] Set up automatic switching so the backup power turns on automatically if the main power fails.
- [ ] Check that the system can run on its own for the extended time by confirming that the on-site fuel or battery supply is sufficient, without relying on any external power generation.
- [ ] Create an auditable alternate power design record that includes equipment details, how the power transfer works, the sizing calculations, and the assumptions used.
- [ ] Run and record an automatic start test (and a sustained running test, or an equivalent that has been validated), and keep the proof for audit purposes.


---

### PE-12 — Emergency Lighting (Control)

This requirement is about making sure the building can help people reach safety if the power goes out. Automatic emergency lighting must be installed, kept in working order, and designed to switch on by itself during a power cut or other power disruption. It must light all emergency exits and the evacuation routes leading from them.

Without this, people may not be able to find exits, could become trapped in poorly lit areas, and evacuation could be delayed or unsafe—especially in places where important equipment is concentrated.

To meet this expectation, the organisation must:
- provide emergency lighting for the relevant areas of the system
- ensure it turns on correctly during tested power-disruption scenarios
- keep it working after any maintenance

It must also have clear written procedures, up-to-date documents showing which exits and routes are covered, named staff responsible for emergency lighting planning, and records showing that emergency lights are tested and that any faults are investigated, followed up, and fixed.

##### Automatic emergency lighting with exit/route coverage register

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Define scope, coverage boundaries, and coverage mapping approach (Emergency Lighting Coverage Register template, route segmentation rules, floors/rooms in scope for application operational teams) | Project Manager | Enterprise | 16h | — |
| Conduct site survey and produce the Emergency Lighting Coverage Register (list each emergency exit and evacuation route segment; capture asset IDs, locations, and coverage rationale) | Facilities/Building Services Manager | Enterprise | 24h | — |
| Specify and procure compliant emergency luminaires/exit signs with automatic activation on loss of normal power; confirm standards alignment with local fire/building requirements | System Design Authority | Enterprise | 16h | £18,000 |
| Install/commission emergency lighting assets and update the register with final installed asset identifiers and coverage confirmation | Infrastructure Lead | Enterprise | 40h | £0 |
| Establish functional test regime and evidence requirements (test frequency, pass/fail criteria, escalation triggers, tester competency/authorisation, evidence fields and retention rules) | Compliance Manager | Enterprise | 16h | — |
| Execute initial functional tests for all registered exits/routes, record auditable evidence in document control, and remediate any failures/degraded performance with re-test | Quality Assurance Lead | Enterprise | 32h | £2,500 |
| Integrate emergency lighting coverage into contingency planning for power disruptions (document updates, roles/escalation, handling when coverage cannot be provided, and linkage to the coverage register) | Business Continuity Manager | Enterprise | 12h | — |

| Total Estimated Effort | 156h |  |
|---|---:|---:|
| Total Estimated Cost |  | £20,500 |

###### Actions Required for Compliance

- [ ] Create an emergency lighting coverage register that lists every emergency exit and the evacuation route sections it lights up for all facility areas relevant to the application.
- [ ] Specify and install emergency lights and exit signs that automatically turn on if the normal power fails, and record the asset identification numbers against the coverage register.
- [ ] Set up and carry out a planned functional test to confirm that automatic activation works correctly and that there is sufficient lighting for every registered exit and route section.
- [ ] Store auditable test evidence (pass or fail result, where it was recorded, date and time, who tested it, and any faults found) in the organisation’s controlled document repository.
- [ ] Set up a corrective action process for any tests that fail or perform poorly, including re-running the tests and updating the coverage register after the fixes are completed.
- [ ] Update the organisation’s contingency plan to include emergency lighting coverage for the relevant system areas, and document what to do (including escalation steps and alternate site options) if emergency lighting coverage cannot be provided.


---

#### PE-12.1 — Essential Mission and Business Functions (Enhancement)

This requirement is about making sure people can still leave safely if the power goes out in the parts of your building that matter most for your work. Without emergency lighting in every essential area, corridors, rooms, and exit routes could become dark, which would increase the risk of injury and cause delays and disruption during an emergency.

To meet this requirement, the organisation must first clearly identify which areas support essential mission and business activities. It must then install and maintain emergency lighting in every part of those areas, including the spaces that lead to emergency exits and evacuation routes.

The organisation must keep clear records showing:
- which areas are covered,
- which exits and routes are supported, and
- who is responsible for planning and maintaining the system.

It must also carry out emergency lighting tests and keep the results. These records must show that all essential areas were checked and that any faults found were followed up and fixed.

##### Essential-areas register and emergency lighting coverage-to-exit mapping

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Confirm scope of “essential mission and business functions” and produce the Essential Areas source list (by floor/zone/room) with named business validators | Business Continuity / Operations Owner | Enterprise | 16h | — |
| Build the Essential Areas Register template (fields, essential-area ID format, ownership, review cadence, change reason, traceability links) and populate v1 for all essential areas | Facilities/Estates Engineering Lead | Enterprise | 24h | — |
| Create the coverage-to-exit matrix structure and mapping rules (coverage source: fitting/lighting zone; destination: emergency exit and evacuation route segment identifiers) | Facilities/Estates Engineering Lead | Enterprise | 20h | — |
| Perform site/plan validation to complete v1 mappings for each essential area to the specific emergency exits and evacuation route segments it illuminates (including any gaps/assumptions log) | Infrastructure Lead | Department | 32h | — |
| Standardise identifiers across floor plans, CMMS/EAM asset records, and test sheets (define ID conventions; update CMMS/EAM reference fields and ensure alignment for a representative sample) | CMMS/EAM Administrator | Enterprise | 24h | — |
| Implement controlled documentation workflow (version-controlled repository, approval workflow, access controls, retention, and audit trail) for the register and matrix | Compliance Manager | Enterprise | 16h | — |
| Define and update inspection/test scope using the matrix (which fittings/areas are in routine tests; ensure test records reference essential-area IDs, exits, and route segments; produce test-evidence checklist) | Operations Lead | Department | 20h | — |
| Run an audit readiness traceability exercise (register → matrix → fittings → latest test evidence) and produce an “evidence pack” plus documented change triggers for layout/occupancy changes | Compliance Manager | Enterprise | 16h | — |

**Total Estimated Effort:** 168h  
**Total Estimated Cost:** £0

###### Actions Required for Compliance

- [ ] Run a business and operations workshop to identify and agree which parts of the facility support the essential mission and business activities.
- [ ] Create an Essential Areas Register using standard room or zone names and assign a responsible owner.
- [ ] Create an emergency lighting coverage matrix that lists each essential area, the emergency lighting fittings or zones that cover it, and the specific exits and evacuation route segments.
- [ ] Store the register and matrix in a controlled, version-managed repository, with an approval workflow.
- [ ] Set up computerised maintenance management system (CMMS) / enterprise asset management (EAM) asset identifiers and test work orders so the test records use the same essential-area identifiers and the same exit and route details.
- [ ] Set clear triggers for changes so that any change to layout or occupancy that affects essential areas requires a review and update of the register and matrix.


---

### PE-13 — Fire Protection (Control)

This requirement is about making sure your buildings can detect a fire early and respond reliably, even if the usual electricity supply fails. If fire alarms and fire-fighting systems are not correctly installed and working, a small fire could go unnoticed for too long, or the equipment used to control the fire might not work when needed—putting people, critical equipment, and business continuity at serious risk.

To meet this expectation, the organisation must install and keep in working order fire detection and fire suppression systems in the relevant facilities. These systems must be powered by a separate, independent power source that is separate from the building’s normal supply (or can be separated), so they continue operating during a power loss. The organisation must also maintain these systems, carry out regular checks and tests, and keep clear records showing that the systems have been inspected, tested, and are ready to use when required.

##### Independent-power fire detection/suppression design and commissioning

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Create an in-scope facility register covering all critical infrastructure facilities and map each room to fire alarm zones/areas (including asset IDs and room-to-zone traceability) | Compliance Manager | Enterprise | 24h | — |
| Perform as-built fire protection engineering documentation for each in-scope facility, explicitly identifying detection components, suppression components, and normal vs independent energy source with isolation points (single-line/power diagrams and panel schedules) | System Design Authority | Enterprise | 56h | — |
| Define commissioning test plan and acceptance criteria for independent power operation for detection/monitoring and suppression control electronics (where present), including test scripts, roles, and safety/permit requirements | Project Manager | Enterprise | 24h | — |
| Commission and verify independent power operation per facility: (1) fire alarm panel/detection monitoring remains operational under normal power isolation, (2) suppression control electronics/pump/valve control reaches intended operating state using independent energy | Security Engineer | Enterprise | 72h | £6,000 |
| Produce controlled evidence pack per facility linking device/zone mapping to the power architecture and commissioning results (device lists, zone mapping, diagrams, panel schedules, commissioning certificates, test results) and store in the controlled repository | Compliance Manager | Enterprise | 32h | — |
| Hand over to operations: update maintenance work instructions and maintenance baseline references to ensure “maintain” is supported by an auditable starting point (including periodic test expectations aligned to commissioning outcomes) | Operations Lead | Enterprise | 24h | — |
| Conduct compliance review and gap remediation for PE-13 coverage across all in-scope facilities (evidence completeness, traceability checks, and sign-off readiness) | Data Protection Officer | Enterprise | 16h | — |

**Total Estimated Effort:** 248h  
**Total Estimated Cost:** £6,000

###### Actions Required for Compliance

- [ ] Create an in-scope facility register and map each room to the fire alarm zones/areas.
- [ ] Create “as-built” fire detection and fire suppression diagrams that show the normal power setup and the separate (independent) power and isolation points.
- [ ] Install fire alarm control panels and the fire detection and monitoring wiring paths with independent confirmation of power (normal power isolated and removed).
- [ ] Commission the suppression control electronics (for example, pump and valve controls where fitted) to confirm they can run independently on their own power supply.
- [ ] Compile a site-level evidence pack that links each device or zone to the site’s power design and to commissioning and testing certificates.
- [ ] Update the maintenance work instructions to refer to the commissioning baseline and the required independent power checks.


---

#### PE-13.1 — Detection Systems — Automatic Activation and Notification (Enhancement)

This requirement ensures that when a fire is detected, the building’s fire alarms automatically activate and immediately alert the correct people, without anyone needing to press a button. If this does not happen, a fire could be found too late, the wrong people could be notified, or emergency response could be delayed—putting lives, the site, and any sensitive activities at risk.

The organisation must make sure its fire detection systems automatically trigger an alert and automatically notify the Facility Security Officer, the Information System Security Officer, and the building fire warden, as well as the local base fire and emergency services dispatch and the on-duty fire response team. It must clearly state who is included on these notification lists, assign named responsibilities for detecting the fire and sending the alerts, and keep written records and evidence (including test results) that the alarms work as intended, including during power disruption using an independent power source.

##### Automatic fire alarm activation with dual internal/external notification

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Confirm current FACP configuration and event-to-output mapping; produce a gap assessment against PE-13(1) (automatic activation + dual internal/external notification) | System Design Authority | Department | 16h | — |
| Design and document the two notification paths from the FACP (internal to {{pe-13.01_odp.01}}; external to {{pe-13.01_odp.02}}), including signalling method, message/annunciation type, and acknowledgement/escalation expectations | Security Engineer | Department | 24h | — |
| Implement FACP programming changes to drive automatic internal notification outputs (annunciators/monitored panel messages/paging gateway as approved) and validate correct role mapping to {{pe-13.01_odp.01}} | Infrastructure Lead | Team | 32h | £3,000 |
| Implement FACP programming changes to drive automatic external notification outputs (monitored transmission to alarm receiving centre/dispatch route) and validate correct routing to {{pe-13.01_odp.02}} with agreed test/acknowledgement behaviour | Infrastructure Lead | Team | 32h | £3,000 |
| Verify independent energy source for notification capability: confirm battery-backed/independent power for FACP and connected communicators/receivers; document endurance assumptions and configuration evidence | Operations Lead | Department | 16h | £1,500 |
| Develop and execute supervised tests for both notification paths, including at least one power-disruption simulation test; capture FACP event logs and test records in an auditable repository | Quality Assurance Lead | Team | 24h | £2,000 |
| Produce compliance evidence pack and change-control artefacts: notification mapping register, test evidence, independent power verification record, and sign-off workflow for FSO/ISSO/building fire warden and dispatch liaison | Compliance Manager | Enterprise | 16h | — |
| Update configuration management and runbook/procedures for ongoing assurance (how to evidence detection-to-notification, periodic test frequency, and how to handle failures/maintenance) | Service Delivery Manager | Department | 16h | — |

**Total Estimated Effort:** 176h  
**Total Estimated Cost:** £9,500

###### Actions Required for Compliance

- [ ] Set up the fire alarm control panel so that fire-detection events automatically start the alarm and notification outputs, without anyone needing to manually trigger them.
- [ ] Map {{pe-13.01_odp.01}} to the approved internal notification routes and record this mapping in an auditable configuration document.
- [ ] Route {{pe-13.01_odp.02}} to the approved external dispatch and receiving signalling path, and confirm what the receiving centre’s tests and acknowledgements should be.
- [ ] Check and record that the notification feature has coverage from an independent power source (for example, a battery backup or other independent power), including for any connected communication devices.
- [ ] Run supervised checks to confirm that internal and external notifications work correctly, and store fire alarm control panel (FACP) event logs and test evidence in a compliance repository.
- [ ] Carry out a power-disruption validation test, following the safety and manufacturer procedures, and record the results to show that notification remains available.


---

#### PE-13.2 — Suppression Systems — Automatic Activation and Notification (Enhancement)

This requirement ensures the fire suppression system can act on its own and immediately raise the correct alarms, even when no one is on site. Without this, a fire could spread before help is called, or the people who need to respond could be missed, delayed, or unable to reach the right responders—especially at night, on weekends, or during planned closures when the site is not continuously staffed.

The organisation must ensure the suppression system automatically starts releasing suppression when needed, and automatically alerts the facility security officer, the system owner, and the designated operations duty officer, as well as the installation fire marshal and the on-call base emergency response team. It must clearly define who these people are, ensure they have the right permissions to respond, and make sure the alerting still works during a power loss by using independent backup power.

##### Configure fire suppression auto-release and resilient multi-recipient alerts

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Confirm current fire panel/suppression controller capabilities and define required auto-release + notification/escalation configuration (including supported outputs/gateway options) | System Design Authority | Enterprise | 16h | — |
| Configure automatic suppression release logic (detection/alarm condition mapping, interlocks, inhibit conditions, and fail-safe behaviour) and document the configuration rationale | Security Engineer | Department | 24h | — |
| Configure resilient multi-recipient alert routing to internal duty roles and external/on-call responders (including message templates, escalation timers, and acknowledgement behaviour) | Platform Engineer | Department | 24h | — |
| Implement/validate independent energy for notification path (battery-backed panel/communicator and/or independent alarm gateway), including expected runtime behaviour during mains loss | Infrastructure Lead | Department | 16h | £3,000 |
| Define and maintain controlled recipient list mapping to authorised access/clearance routes (internal access levels and external responder entry arrangements) and produce an auditable change-controlled register | Compliance Manager | Enterprise | 16h | — |
| Execute and record acceptance tests: (1) auto-release verification, (2) multi-recipient delivery verification, (3) power-loss simulation showing notifications still transmit, and (4) escalation/acknowledgement timing evidence | Quality Assurance Lead | Department | 24h | £1,500 |
| Produce audit-ready evidence pack (panel/communicator event logs, unattended test records, configuration snapshots, and sign-off summary aligned to PE-13(2) enhancement expectations) | Compliance Manager | Enterprise | 16h | — |

**Total Estimated Effort:** 136h  
**Total Estimated Cost:** £4,500

###### Actions Required for Compliance

- [ ] Set up the fire suppression controller and fire panel so they automatically release the suppression system when the agreed detection or alarm conditions are met.
- [ ] Set up alarm and notification routing so alerts are sent to the internal on-call duty roles list (facility security officer, system owner, and the designated operations duty officer).
- [ ] Set up alarm and notification routing so alerts are sent to the external on-call responders list (the installation fire marshal and the on-call base emergency response team).
- [ ] Put in place and document rules for when escalations and acknowledgements happen, so that external responders are informed if internal teams do not acknowledge within the agreed time limits.
- [ ] Test that the notification system can still work independently during a power failure by running a controlled power-loss test and recording the results.
- [ ] Create and keep up to date a list showing which notification recipients or job roles need which facility access permissions or security clearances to respond.
- [ ] Record and keep records of panel/communicator event logs and unattended test evidence showing when suppression was activated and the times alerts were sent.


---

#### PE-13.4 — Inspections (Enhancement)

This requirement is about making sure your building’s fire safety is checked properly and any issues are fixed quickly, so small problems do not become a serious incident. Without an annual inspection by the right, properly qualified fire safety professionals, problems with fire alarms, sprinklers, fire extinguishers, or other fire safety arrangements could be missed, putting people and property at risk.

To meet this expectation, the organisation must arrange an annual fire safety inspection for each relevant facility by authorised and qualified inspectors, such as fire inspectors from the state, county, or city, and fire marshals. The organisation must keep the inspection records and make sure any deficiencies found are formally recorded and corrected within 30 days.

If the inspection requires access to areas that may contain sensitive information, the organisation must provide an escort for the inspectors during those parts of the visit.

##### Annual fire inspection workflow with 30-day deficiency closure

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define workflow requirements, data model, and acceptance criteria for “Fire Protection Inspection” and “Deficiency” (incl. 30-day SLA, exception governance, escort evidence requirements) | Compliance Manager | Enterprise | 24h | — |
| Create and govern the “Authorised Inspector” register (data fields, qualification/jurisdiction evidence requirements, approval process, periodic review cadence) | Fire Safety/Facilities Manager | Enterprise | 32h | — |
| Configure ITSM/EAM workflow: inspection record creation per facility/event, mandatory fields, inspector validation against authorised register, deficiency due date calculation (inspection date + 30 days) | ITSM/EAM Administrator | Enterprise | 56h | — |
| Implement deficiency tracking and closure guardrails: link deficiencies to corrective actions/work orders, enforce closure evidence attachment, prevent completion after SLA expiry without approved exception record | DevOps Lead | Enterprise | 48h | — |
| Implement escort step for sensitive-area access: flagging logic, mandatory escort names and access time windows, integration/link to visitor management logs (where available) | Security Engineer | Enterprise | 40h | — |
| Build audit-ready evidence packs with immutable audit trail: inspection summary, deficiency list, due/closure dates, evidence links, escort evidence (if applicable), and export/reporting for auditors | Platform Engineer | Enterprise | 40h | — |
| Test, pilot, and remediate: end-to-end workflow testing (happy path + failure modes), user acceptance testing with Facilities/Compliance, and go-live readiness checks | Quality Assurance Lead | Enterprise | 32h | — |
| Operational rollout and training: release notes, runbooks, role-based access setup, training sessions for Facilities, Compliance, and Security escorting stakeholders | Project Manager | Enterprise | 24h | — |

**Total Estimated Effort:** 296h  
**Total Estimated Cost:** £0

###### Actions Required for Compliance

- [ ] Create and keep an authorised inspector register, including proof of each inspector’s qualifications and the jurisdictions they are allowed to inspect, for every approved inspector identity.
- [ ] Set up an IT service management (ITSM) and enterprise asset management (EAM) workflow for “fire protection inspection”. Make the following details mandatory: the site or facility, the inspector’s identity, a reference for the inspection report, and a list of any deficiencies found.
- [ ] Set up controls that automatically calculate the due date for any deficiency as the inspection date plus 30 days, and prevent the case from being closed unless there is a linked corrective action and supporting closure evidence.
- [ ] Add a “sensitive area” flag, and require the names of the escort(s) and proof of the access time window whenever inspections enter areas that contain sensitive information.
- [ ] Set up automated generation of audit packs that brings together inspection reports, tracking of identified issues, proof that issues have been closed, and proof of escort activity, with an unchangeable record of all audit actions.
- [ ] Run a trial inspection process for one facility, check that every identified issue is fixed within 30 days, and produce complete evidence for the audit.


---

### PE-14 — Environmental Controls (Control)

This requirement is about keeping the room that houses your important equipment at the right climate, and ensuring you are warned immediately if conditions move outside the safe range. If temperature and dampness are allowed to vary too much, the equipment can overheat, be damaged, or become unreliable—potentially stopping services your business depends on.

To meet this expectation, the organisation must:
- Identify the specific facility and room where the system is located.
- Keep the temperature between **18°C and 27°C** and the **relative humidity between 40% and 60%** at all times.
- Continuously monitor temperature and humidity.
- Raise alerts immediately whenever either temperature or humidity goes outside the allowed limits, and send those alerts to the named people responsible for oversight and response.

The organisation should also:
- Document how these settings are maintained.
- Assign clear responsibilities.
- Include the environmental arrangements in its planning documents.
- Keep dated records of temperature and humidity readings, including evidence that alerts were raised for any out-of-range events.

##### Calibrated temp/RH monitoring with 18–27°C and 40–60% alerts

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Confirm scope of monitored room(s)/zones and produce room-to-application environment mapping (incl. production and DR if applicable) | Project Manager | Enterprise | 8h | — |
| Specify sensor placement rules and monitoring requirements (sampling rate, alert thresholds, hysteresis/suppression approach, evidence retention expectations) and get sign-off | System Design Authority | Enterprise | 16h | — |
| Procure calibrated temperature/RH sensors (with calibration certificates) and any required mounting/connection accessories for each scoped zone | Infrastructure Lead | Department | 8h | £6,000 |
| Install sensors, label with unique IDs, record calibration dates/due dates, and verify readings against a reference instrument for acceptance | Security Engineer | Department | 24h | £1,200 |
| Configure monitoring platform: continuous ingestion, time-stamped logging, threshold breach logic for 18–27°C and 40–60% RH, and alert suppression/hysteresis to reduce nuisance | DevOps Lead | Enterprise | 24h | £3,000 |
| Integrate alert delivery with ITSM workflow (named operational owners, ticket creation/update, escalation paths, and audit-traceable linkage) | Operations Lead | Enterprise | 16h | — |
| Create and approve environmental response runbook (immediate actions, escalation, corrective action steps) and ensure corrective actions are recorded against tickets | Compliance Manager | Enterprise | 16h | — |
| Update security planning documentation to reference the control implementation (scope, targets, monitoring, response, and evidence sources) and complete audit evidence checklist | Data Protection Officer | Enterprise | 8h | — |
| **Total Estimated Effort** |  |  | **120h** |  |
| **Total Estimated Cost** |  |  |  | **£11,200** |

###### Actions Required for Compliance

- [ ] Identify and record the exact facility room or rooms where the application infrastructure is located, and assign each sensor to the relevant room.
- [ ] Install temperature and humidity sensors and record each sensor’s ID, the calibration date, and the next calibration due date.
- [ ] Set the monitoring system alert thresholds to temperatures of 18–27°C and humidity of 40–60% relative humidity (RH), with alerts when these limits are exceeded.
- [ ] Set up continuous logging of temperature and humidity readings, with time-stamped records kept for an appropriate period so they can be used as audit evidence.
- [ ] Set up alert routing in the IT service management (ITSM) system so alerts are sent to named operational owners and automatically create traceable tickets.
- [ ] Publish and keep up to date a step-by-step guide (runbook) for responding to out-of-range alerts, and record the corrective actions taken for each alert or ticket.
- [ ] Link the environmental monitoring scope, goals, and response process to the system security planning documentation.


---

#### PE-14.1 — Automatic Controls (Enhancement)

This requirement is about automatically keeping the areas where your important equipment is stored at safe temperature and moisture levels, so conditions do not slowly move into harmful extremes. Without this, heat, dampness, or excessive dryness can gradually damage or wear out equipment, which can cause failures, downtime, or expensive repairs.

The organisation is expected to install automatic temperature and humidity sensors in the relevant areas, continuously monitor the readings, and ensure the heating, ventilation and air conditioning system automatically adjusts to keep conditions within agreed safe limits. If the readings go outside those limits, the system must automatically raise alarms and record what happened, including the safe thresholds and how the alarms behave.

The organisation must also document the safe limits, the site layout, the automated setup, and the procedures for what staff should do if monitoring or automatic adjustment fails. Named responsibilities must be assigned, and evidence must be kept to show that monitoring, adjustments, and alarms are working as intended.

##### BMS-integrated temperature/humidity auto-control with alarm logging

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Define environmental limits per housing zone (temp/RH ranges, warning/critical thresholds, hysteresis/deadbands) and map to HVAC control modes/stages | Compliance Manager | Enterprise | 24h | — |
| Sensor deployment plan and integration design (sensor types, placement, sampling rates, data points, BMS tag naming, redundancy/health checks) | Infrastructure Lead | Enterprise | 32h | — |
| Procure and install/commission temperature & humidity sensors for all housing zones; validate continuous collection and data quality | Operations Lead | Department | 40h | £18,000 |
| Configure BMS/building controller HVAC auto-adjustment rules (control logic, setpoint/mode transitions, fail-safe behaviour, manual override constraints) | System Design Authority | Department | 48h | — |
| Configure alarm points and escalation workflow (warning/critical thresholds, acknowledgement/escalation timing, notification channels to facilities/on-call) | Security Engineer | Enterprise | 24h | — |
| Implement audit-ready logging and evidence (log schema, timestamps, retention alignment, capture of sensor readings, threshold crossings, and HVAC control actions) | Data Protection Officer | Enterprise | 32h | — |
| Commissioning/validation tests and evidence pack (simulate threshold events, verify HVAC response and alarm triggers, confirm logs; produce test report and sign-off) | Quality Assurance Lead | Enterprise | 24h | £2,500 |
| Update operating procedures and system security plan references (environmental procedures, control identifiers, alarm handling, evidence retention, change control notes) | Compliance Manager | Enterprise | 16h | — |

**Total Estimated Effort:** 260h  
**Total Estimated Cost:** £20,500

###### Actions Required for Compliance

- [ ] Identify and record all building areas used for equipment, and match them to the corresponding environmental control zones, with documented zone boundaries.
- [ ] Set safe operating limits for temperature and humidity (warning and critical levels). Use hysteresis and deadbands so the system does not switch back and forth repeatedly.
- [ ] Connect temperature and humidity sensors to the building management system (BMS) or building controller, and collect data continuously.
- [ ] Set up building management system (BMS) control logic to automatically adjust heating, ventilation and air conditioning (HVAC) operation based on sensor readings, without any manual control actions required.
- [ ] Set up automatic alert points and define how alerts are escalated and notified when warning or critical thresholds are exceeded.
- [ ] Turn on and confirm time-stamped logging for sensor readings, threshold crossings, and heating, ventilation and air conditioning (HVAC) control actions; keep the records for the period required by organisational policy.
- [ ] Run commissioning tests to recreate the expected trigger conditions and confirm that the alarms, heating, ventilation and air conditioning (HVAC) responses, and log entries behave exactly as described in the documentation.


---

#### PE-14.2 — Monitoring with Alarms and Notifications (Enhancement)

This requirement is about making sure the building where the system is housed can detect dangerous environmental changes early and alert the right people immediately. By continuously checking conditions such as temperature and humidity, the organisation reduces the risk of harm to staff and helps prevent damage to equipment that can occur when conditions move outside safe limits. This can otherwise lead to outages, expensive repairs, or safety incidents.

To meet this requirement, the organisation must install environmental monitoring in the facility where the system is kept. It must be set up so that, when readings show potentially harmful changes, it triggers an audible alarm and/or a clear visual warning. It must also send real-time notifications to the Facilities Operations Duty Officer, the Environmental Health and Safety (EHS) lead, and the on-call Network Operations Centre engineer.

The alerts must be sent promptly to these named roles. The organisation must also keep records showing what was monitored and what triggered each alarm, so incidents can be reviewed and handled effectively.

##### Environmental monitoring alarms with role-based real-time notifications

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Confirm authoritative source of truth (BMS/environmental monitoring platform), sensor inventory, and supported alarm/fault conditions; produce implementation scope and data mapping (zone/sensor → readings → events) | System Design Authority | Enterprise | 16h | — |
| Define “potentially harmful” alarm thresholds and sensor fault/invalid reading rules with EHS approval; document rationale, manufacturer limits, and escalation expectations | Compliance Manager | Enterprise | 24h | — |
| Configure alarm thresholds and event generation in the monitoring platform (threshold breach + sensor fault where supported) across relevant facility areas; implement change-controlled configuration baseline | Infrastructure Lead | Department | 32h | — |
| Implement local audible/visual annunciation in the facility area(s) and validate real-time behaviour (alarm activation, reset logic, visibility, and fail-safe handling) | Operations Lead | Department | 24h | £6,000 |
| Configure role-based real-time notifications with on-call rotation awareness (Facilities Operations Duty Officer, EHS lead, on-call NOC engineer); implement secure notification routing and message templates | DevOps Lead | Enterprise | 32h | £3,500 |
| Centralise event logging for auditability (timestamped readings, measured values, thresholds, sensor/zone identifiers, alarm state transitions, notification delivery outcomes) and integrate with SIEM/monitoring with evidence retention | Security Engineer | Enterprise | 40h | £8,000 |
| Harden alerting integration (least-privilege service accounts, network allow-listing/segmentation, secrets handling, access reviews, and change-controlled updates); complete security validation and runbook updates | Cyber Security Lead | Enterprise | 24h | £4,000 |

**Total Estimated Effort:** 212h  
**Total Estimated Cost:** £21,500

###### Actions Required for Compliance

- [ ] Confirm the system’s facility coverage, and link each monitored area or zone to the environmental sensors used by the building management system (BMS) and monitoring platform.
- [ ] Set up the temperature and humidity sensors, and confirm that live readings are being collected correctly, that each sensor is working properly, and that the system is checking and collecting data at the expected intervals.
- [ ] Work with the Environment, Health and Safety (EHS) team to set clear “potentially harmful” alarm thresholds, then put them in place as configurable settings that are managed through change control.
- [ ] Set up local audible and/or visual alarms for events that reach alarm level in the relevant facility area(s).
- [ ] Set up real-time alerts to be sent to the Facilities Operations Duty Officer, the environmental health and safety (EHS) lead, and the on-call network operations centre (NOC) engineer, using the organisation’s on-call schedule integration.
- [ ] Set up central logging for alarm events in the organisation’s monitoring and logging system, including the time of the event, the measured value, the threshold, the sensor or zone identifier, and whether the notification was successfully delivered.
- [ ] Improve the alerting connection by using service accounts with the minimum required permissions, restricting network access through allow-lists and network segmentation, and limiting who can change building management system (BMS) and monitoring settings.


---

### PE-15 — Water Damage Protection (Control)

This requirement is about preventing water leaks from turning into expensive damage. It requires main water shut-off valves or local isolation valves for the areas where important equipment is kept, such as server rooms or data centres. If these valves are not installed and usable, a leak can spread quickly, damaging critical equipment, disrupting services, and leading to costly clean-up and downtime.

To meet this requirement, the organisation must:
- install the correct shut-off or isolation valves for the facility’s water supply, and
- keep the valves physically accessible and in working order.

The organisation must also:
- keep clear, up-to-date records showing where the valves are and how to operate them, and
- ensure named key staff know the exact locations and the step-by-step process to shut off the water when needed, including an organisational process for activating the shut-off and recording that it has been done.

##### Accessible master shutoff/isolation valves with tested activation

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Conduct facilities-led system area to water supply zone mapping (as-built drawing review + site walkdowns) and produce a draft “protected area ↔ valve” mapping | Facilities Engineering/Technician | Department | 24h | — |
| Create the valve register template and populate it with valve IDs, exact locations, protected area names, normal position, and step-by-step activation instructions | Compliance Manager | Enterprise | 16h | — |
| Install/replace required master shutoff or isolation valves where gaps exist, ensuring physical accessibility (no blocked access) and correct OPEN/CLOSE direction markings | Infrastructure Lead | Department | 40h | £6,000 |
| Implement labelling and signage at each valve access point (unique identifier, protected area reference, operational markings) and along access routes where needed | Operations Lead | Department | 16h | £1,200 |
| Define and document the emergency activation workflow (authorisation, execution, notification, recording requirements) and align it to incident management/BCP processes | Security Operations / Incident Management Lead | Enterprise | 12h | — |
| Establish functional readiness checks: risk-based maintenance schedule (incl. at least semi-annual checks for high-risk areas), evidence capture fields, and sign-off process | Service Delivery Manager | Enterprise | 20h | — |
| Perform functional readiness testing for all registered valves and retain audit evidence (date, valve ID, technician, outcome) | Facilities Engineering/Technician | Department | 24h | — |
| Deliver training and validation: identify key personnel, run walkdowns/competency checks, and complete at least one tabletop/drill within the last year (or per cadence) | Project Manager | Enterprise | 18h | — |

**Total Estimated Effort:** 170h  
**Total Estimated Cost:** £7,200

###### Actions Required for Compliance

- [ ] Create a site map that links each critical server location to the specific water supply line(s) and the required main shut-off or isolation valve(s).
- [ ] Install each required valve and give it a unique label showing the protected area name, with clear markings showing the correct OPEN and CLOSE directions.
- [ ] Remove any access barriers and confirm that stop valves can be reached and operated by authorised key staff without unreasonable delay.
- [ ] Set up and carry out a risk-based schedule of functional readiness tests (including shutting off and restoring service), and keep the supporting evidence for each valve by its valve identification (ID).
- [ ] Maintain a controlled list of valves and a step-by-step emergency activation procedure, including who is authorised to approve it, how it is carried out, and who must be notified.
- [ ] Identify the key staff members and complete regular site walkdowns and skill checks to confirm the valves are in the correct position and that the activation steps are carried out correctly.


---

#### PE-15.1 — Automation Support (Enhancement)

This requirement is about quickly spotting water where it should not be and ensuring the right people are informed immediately. If leaks are not noticed near the systems that keep the business running, they can cause damage, service interruptions, and expensive repairs—and the problem may worsen before anyone realises what is happening.  

To meet this expectation, the organisation must automatically detect water near the system by using water leak detection sensors placed in the relevant areas of the facility. When water is detected, the system must automatically trigger both an on-site audible warning and an on-site visible warning.  

At the same time, it must send an alert to the organisation’s monitoring setup so that the facilities duty officer and the on-call infrastructure operations lead are notified promptly, with enough information to act—including the location of the issue and the time it was detected.

##### Water leak sensors with local alarms and monitoring alerts

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Confirm alert recipients, routing method, and on-call schedule mapping (facilities duty officer + on-call infrastructure operations lead), including paging/SMS/voice/team messaging integration requirements | Compliance Manager | Enterprise | 8h | — |
| Select sensor/gateway model(s) and define technical requirements for local audible + visible alarm independence and event payload fields (zone/location, device ID, timestamp) | System Design Authority | Department | 16h | £6,000 |
| Design sensor placement plan for “near the system” coverage, including zone identifiers, coverage boundaries, and installation constraints for electrical cabinets/UPS/server perimeters/cable routes | Infrastructure Lead | Department | 12h | — |
| Procure and stage water leak sensors, local alarm components/gateways, cabling/ancillaries, and any required integration licences (per environment: production + DR/test as applicable) | Project Manager | Business Unit | 8h | £18,000 |
| Configure and wire local alarm behaviour to trigger immediately upon detection (independent of monitoring platform), and implement gateway-to-monitoring event forwarding | Security Engineer | Team | 24h | £— |
| Implement monitoring platform ingestion, normalisation, and alert rules with role-based routing to the duty officer and on-call infrastructure operations lead; ensure alert includes required fields | DevOps Lead | Team | 20h | £— |
| Execute end-to-end validation tests per zone (local audible/visible alarm response + monitoring alert delivery/ack where supported) and produce acceptance evidence pack for audit | Quality Assurance Lead | Department | 16h | — |
| Establish evidence retention and operational runbook updates (log retention, incident/ack workflow, maintenance/testing cadence, and change control references) | Operations Lead | Enterprise | 12h | — |

**Total Estimated Effort:** 116h  
**Total Estimated Cost:** £24,000

###### Actions Required for Compliance

- [ ] Confirm who should receive alerts, and set up the monitoring system so alerts are routed to the facilities duty officer and the on-call infrastructure operations lead.
- [ ] Select and install water leak detection sensors with local audible and visual alarms in all facility areas that are close to the system.
- [ ] Give every sensor a stable zone or location identifier, and make sure each event includes the zone, the time it occurred (timestamp), and the sensor or device identifier.
- [ ] Set up the facility alarm panel or gateway integration so that water-detection alerts are sent to the monitoring platform.
- [ ] During sensor tests, check that local audible (sound) and visible (light) alarms work independently of the monitoring platform.
- [ ] Run controlled tests in each network zone and record proof that local alarms activated and that monitoring alerts were delivered and acknowledged.


---

### PE-16 — Delivery and Removal (Control)

This requirement is about ensuring that only approved items can be brought onto your site or taken off it, and that you can show what happened. Without this, unauthorised equipment, storage devices, or software updates could be smuggled in or removed, which could cause disruption, data loss, or unauthorised changes to systems.

To meet this expectation, the organisation must clearly set out which types of items are allowed to enter and leave. This includes hardware such as servers, workstations, and network devices; removable storage media; software or firmware updates; and parts. It must only allow items onto the site when they have been authorised for entry, and it must manage the entry process so unauthorised items cannot be taken straight into sensitive areas.

Similarly, it must only release items when they are authorised for exit, and it must control the exit process. Finally, it must keep accurate records of all system components that enter and exit the facility.

##### Authorised delivery/removal workflow with immutable scan-and-ticket records

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define and publish the “In-scope Components” catalogue (component types, mandatory identifiers, validation rules, and software/firmware artefact requirements) | Compliance Manager | Enterprise | 24h | — |
| Configure the single intake/dispatch workflow in the ticketing/workflow system (mandatory fields, approval routing, authorisation reference generation, and state model for created/approved/received/checked-in/released/returned) | Service Delivery Manager | Enterprise | 40h | — |
| Implement barcode/QR scanning at controlled receiving/dispatch points and bind scans to ticket line items (check-in/check-out UI/API, validation logic, mismatch blocking) | Platform Engineer | Department | 48h | £6,000 |
| Design and implement immutable/append-only audit logging for workflow events and scan events (WORM-capable storage or immutable event store, retention, query/audit views) | Security Engineer | Enterprise | 56h | £18,000 |
| Add cryptographic binding for software/firmware updates (store authorised artefact hash/checksum and signature verification reference; enforce match during intake; record verification outcome) | Security Engineer | Enterprise | 40h | £4,000 |
| Implement exit reconciliation against the same authorisation record (dispatch check-out reconciliation, asset register cross-check where applicable, exception workflow for mismatches) | Operations Lead | Department | 32h | — |
| Run end-to-end pilot for at least one full delivery/removal cycle and produce audit-ready evidence pack (test scripts, evidence screenshots/exports, operator acceptance, remediation of gaps) | Project Manager | Enterprise | 24h | — |

Total Estimated Effort: **264h**  
Total Estimated Cost: **£28,000**

###### Actions Required for Compliance

- [ ] Create and publish an in-scope components catalogue that covers hardware, removable media, software and firmware updates, and parts, including the required identifiers.
- [ ] Set up a ticket or workflow approval process that creates a unique authorisation reference for every delivery and removal event, with required fields.
- [ ] Set up barcode and QR code scanning at controlled receiving and dispatch points to link physical items to the correct ticket line items.
- [ ] Record workflow events and scan events in an unchangeable, add-only logging system, including the operator’s identity and the time (timestamp) each event occurred.
- [ ] Require that software or firmware update submissions include and are checked for an authorised file hash/checksum and that the signature verification reference is provided and verified.
- [ ] Carry out reconciliation checks when a release is being completed to stop the release if anything does not match, and send any exceptions to the appropriate team for investigation.


---

### PE-17 — Alternate Work Site (Control)

This requirement is about making sure staff can work safely from approved alternative places—such as United States Department of Defense (DoD) government facilities and pre-approved private homes—without reducing existing protections.

The main risk is that, when staff are away from their usual workplace, access may not be controlled tightly enough. This could allow unauthorised people to enter, could expose sensitive information if a work device is lost or accessed, and could mean suspicious activity goes unnoticed—particularly if something goes wrong and staff do not know who to contact.

To meet this expectation, the organisation must:
- Keep a documented, approved list of the specific alternative locations that are allowed.
- For each approved location, require strong identity checks for every login.
- Protect work devices using encryption.
- Use only an approved secure method for remote connections.
- Limit staff access rights to only what they need for their role.
- Record activity so it can be reviewed.

The organisation must also check and document how well these protections work at each alternative site. Finally, it must provide a clear, easy-to-find way for employees to contact the organisation’s information security and privacy personnel immediately to report incidents.

##### Authorised alternate work sites with enforced secure access

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define governance for the Alternate Work Site Register (site types, approval workflow, approver identity requirements, effective dates, change history fields, and audit evidence standards) | Compliance Manager | Enterprise | 24h | — |
| Build and publish the auditable Alternate Work Site Register (authorised DoD facilities + pre-approved private residences) with approval trail, effective dating, and change history export for audits | Project Manager | Enterprise | 32h | £8,000 |
| Implement secure access path enforcement by binding remote sessions to the authorised site register (approved secure VPN/ZTNA policy, session origin validation, and deny-by-default for non-authorised origins) | Network/Secure Access team | Enterprise | 40h | £25,000 |
| Configure enterprise identity conditional access for alternate-site sessions (MFA enforcement, phishing-resistant authenticator requirement, device encryption + compliance checks, and policy exceptions governance) | Security Engineer | Enterprise | 48h | £12,000 |
| Implement least-privilege controls for alternate-site sessions (role mapping, privileged action time-bound elevation, and session-level auditing hooks) | Software Lead | Enterprise | 32h | — |
| Centralise and validate audit logging for alternate-site activity (SIEM ingestion for identity sign-in, VPN/ZTNA session events, endpoint compliance events; ensure correlation fields and retention meet policy) | SOC/SIEM team | Enterprise | 40h | £15,000 |
| Establish incident communication contact point and integrate into employee alternate-site guidance (single channel/number, escalation routing, and confirmation it is reachable from alternate work sites) | Service Delivery Manager | Enterprise | 16h | £2,000 |
| Perform effectiveness assessment per alternate work site type/site and produce audit-ready evidence pack (KPIs, success/failure rates, device compliance attainment, log completeness, remediation actions and tracking) | Compliance Manager | Enterprise | 24h | — |

**Total Estimated Effort:** 256h  
**Total Estimated Cost:** £62,000

###### Actions Required for Compliance

- [ ] Set up an auditable list of approved alternate work locations for Department of Defense (DoD) sites and pre-approved residences, including the approver’s identity, the start and end dates, and a record of all changes.
- [ ] Set up conditional access so that multi-factor authentication (MFA) is required for every sign-in coming through the approved secure virtual private network (VPN) or approved access route.
- [ ] Require endpoint encryption and compliance checks before granting access, and automatically block or quarantine devices that do not meet the requirements.
- [ ] Use role-based access control (RBAC) and time-limited, fully recorded (audited) permission increases for privileged actions during sessions at an alternate site.
- [ ] Integrate identity sign-in records, virtual private network (VPN) or zero trust network access (ZTNA) session records, and endpoint compliance logs into the security information and event management (SIEM) system, using consistent event fields so they can be reviewed for alternate sites.
- [ ] Set up and test one single incident reporting contact point for security and privacy, and make sure it can be reached from alternate work sites. Include this contact in the communications sent to staff about access from alternate sites.
- [ ] For each alternate work site type and site, carry out and record checks to confirm effectiveness, using access and compliance evidence, and track any required fixes until they are completed and closed.


---

### PE-18 — Location of System Components (Control)

This expectation is about placing important equipment in the correct physical locations inside your buildings. This reduces the risk of damage and makes it harder for people who should not access the equipment to tamper with it or listen to information.

Without this, floods, fires, vandalism, terrorism, and electrical problems could damage the equipment. It could also be interfered with, or information being sent or spoken could be intercepted, by unauthorised people who are near entrances or public areas.

To meet this expectation, the organisation must set out and follow documented rules for where each item of equipment is placed. These rules must be based on a written list of relevant risks, such as floods, fires, terrorism, vandalism, electromagnetic effects, and electrical interference. The organisation must record where each item is located and which approved rooms or areas it is in. It must include this approach in its system plan, appoint named people to make and review placement decisions, and keep evidence showing the process is followed when equipment is installed, moved, or upgraded.

##### Hazard-based component placement standard with location evidence

- Category: Manual
- Priority: High

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Draft the Hazard-based Placement Standard mapping each pe-18_odp hazard category (floods, fires, terrorism, vandalism, EMP, electrical interference, other incoming EM radiation) to concrete placement rules (approved areas, rack/enclosure requirements, segregation/separation expectations, and entry/public proximity restrictions) | Compliance Manager | Enterprise | 24h | — |
| Define the Approved Location Catalogue with unique location identifiers down to evidence granularity (building → floor → room → rack/cabinet → mounting position), including controlled/restricted vs higher-risk zones and the hazard-rule set references | System Design Authority | Enterprise | 20h | — |
| Establish the placement decision workflow for installation/relocation/upgrades, including validation against hazard-based placement rules and an exception process (risk acceptance, time limits, and compensating controls) | Project Manager | Enterprise | 16h | — |
| Update authoritative asset record / CMDB/ITAM integration requirements to store current location ID, placement date, component identifier, and the hazard-rule set applied (including required data fields and ownership) | Data Protection Officer | Enterprise | 18h | — |
| Define and standardise placement evidence requirements for change completion (photo guidance with readable identifiers, evidence naming conventions, minimum evidence set, and audit retention expectations) | Operations Lead | Enterprise | 12h | — |
| Update the System Security Plan to include PE-18 placement requirements, named responsibilities, and explicit traceability to the Placement Standard and exception criteria | Security Engineer | Enterprise | 10h | — |
| Pilot the standard with a representative set of components and facilities, validate audit readiness (location accuracy, evidence completeness, exception handling), and refine documentation/workflow based on findings | Service Delivery Manager | Business Unit | 14h | — |

**Total Estimated Effort:** 114h  
**Total Estimated Cost:** £0

###### Actions Required for Compliance

- [ ] Document a hazard-based placement standard that maps each PE-18 ODP hazard to specific, approved location rules.
- [ ] Create and keep an approved list of locations (building, floor, room, rack, cabinet, and mounting identifiers) that includes information about controlled access.
- [ ] Define and publish a placement procedure for installing, moving, and upgrading systems that requires choosing an approved location.
- [ ] Assign named people to make placement decisions and to carry out information security reviews, and include these responsibilities in the system security plan.
- [ ] Require change records to include proof of where the item was placed (for example, the room, rack, or cabinet identifiers) and to link the component to the approved location ID.
- [ ] Set up an exception process for any deviations, including written approval of the risk being accepted, when that approval expires, and what extra safeguards (compensating controls) will be put in place.


---

### PE-19 — Information Leakage (Control)

This requirement is about preventing sensitive information from “leaking” through hidden electrical or radio signals that could be detected outside your system. Without these protections, someone nearby could potentially capture those signals and piece together confidential information, creating a serious risk to privacy, commercial secrets, and legal compliance.

To meet this requirement, the organisation must have a documented plan showing how it will protect both the system and the building area where it is located from signal leakage. The plan must also include clear, step-by-step instructions for staff on how they will control and reduce unwanted emissions.

The organisation must name specific individuals who are responsible for (1) the physical environment and (2) information security. It must put in place the appropriate technical and building measures to limit emissions, and ensure these measures are kept in place and effective during installation, maintenance, and any changes.

The organisation must also carry out electromagnetic emissions testing, keep the evidence and results, and reference them in the system’s security plan and related records.

##### EM leakage protection programme with shielding standards and test evidence

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define EM leakage protection baseline requirements per in-scope environment (production/test/DR): shielding/containment expectations, approved enclosures/parts, grounding/bonding rules, cable/power routing, penetration/enclosure integrity requirements, and acceptance criteria | Security Architect | Enterprise | 40h | — |
| Produce installation & maintenance procedures/checklists for technicians, including verification steps for enclosure integrity, shielding/filters, grounding/bonding, approved cabling/routing, and evidence capture requirements | Facilities/Infrastructure Engineering Lead | Enterprise | 32h | — |
| Implement EM leakage change control gate: update change management workflow to require EM leakage impact assessment for relevant modifications; define block/rollback criteria and required evidence outputs | Project Manager | Enterprise | 24h | — |
| Establish programme governance and named accountability: assign accountable roles for facility/environmental EM controls and information security activities; define RACI, approval workflow for baseline and security-plan updates, and escalation/exception handling | Compliance Manager | Enterprise | 16h | — |
| Plan and execute EM emissions/emanation testing for each in-scope configuration (or documented equivalence): define test scope, operating states, standards/methods, sampling approach, and retest triggers after approved changes | Operations Lead | Enterprise | 24h | £18,000 |
| Build auditable evidence pack template and repository approach: immutable identifiers, configuration details, test method/standard, results, pass/fail mapping, and linkage to change records and security-plan references | Data Protection Officer | Enterprise | 16h | — |
| Update the system security plan to reference the EM leakage baseline, installation/maintenance procedures, technical mechanisms installed, and exact EM test report identifiers/dates with links to supporting records | Security Architect | Enterprise | 20h | — |

**Total Estimated Effort:** 172h  
**Total Estimated Cost:** £18,000

###### Actions Required for Compliance

- [ ] Define and get approval for a baseline for electronic mail (EM) leakage protection for each hosting environment in scope, based on the confidentiality level and the organisation’s acceptable risk level.
- [ ] Publish installation and maintenance checklists that require proper shielding and containment, correct grounding and bonding, and use of only approved cabling and power routing methods.
- [ ] Update the change management process to require an “electromagnetic (EM) leakage” impact assessment and evidence to be kept for any change to an enclosure, cabling, or power/facility equipment.
- [ ] Assign named, responsible roles for facility and environmental environmental management (EM) controls, and for information security decisions related to environmental management (EM) leakage.
- [ ] Plan and carry out electromagnetic (EM) emissions and radiation testing for each in-scope configuration (or an equivalent configuration that is documented) and record permanent (unchangeable) test report reference numbers.
- [ ] Update the system security plan to reference the electromagnetic (EM) leakage baseline, the related procedures, the installed safeguards, and the corresponding electromagnetic (EM) test report reference IDs and dates.


---

#### PE-19.1 — National Emissions Policies and Procedures (Enhancement)

This requirement is about making sure your organisation’s equipment, the ways it sends information, and the connections it uses are protected in line with the United Kingdom’s (or other relevant national) rules for stopping sensitive information from being revealed through unintended signals. If this is not done, confidential information could be seen by the wrong people because the physical setup and technical connections of systems, links, and network routes do not provide the level of protection needed for the information being handled.

To meet this expectation, the organisation must:
- identify which national rules on emissions and information leakage apply to each type of information; and
- apply the required protections to the relevant parts of the systems, the data routes used to move information, and the networks those systems connect to.

The organisation must also:
- document clear, step-by-step procedures for preventing and handling leakage;
- keep design and configuration records that show it is meeting the rules;
- include these requirements in the system’s plan;
- assign named responsibilities; and
- check that the settings actually put in place match what the rules require.

Any exceptions must be formally recorded and limited to a defined time period.

##### EMSEC/TEMPEST category mapping to component, comms and network baselines

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Establish EMSEC/TEMPEST control catalogue for components, communications, and networks (with clause references and required evidence artefacts) | Compliance Manager | Enterprise | 56h | £— |
| Define repeatable category-to-baseline mapping workflow from information classification model to EMSEC/TEMPEST catalogue entries (including mapping rules, versioning, and audit trail) | Data Protection Officer | Enterprise | 48h | £— |
| Generate system security plan content and checklists per information category (components/comms/networks) and integrate into existing SDLC/security plan templates | Security Engineer | Enterprise | 40h | £— |
| Implement configuration baselines and automated drift/compliance checks aligned to the generated per-category baselines (network segmentation templates, secure comms settings, approved crypto/network parameters where applicable) | DevOps Lead | Enterprise | 72h | £18,000 |
| Document TEMPEST-aligned leakage/emissions procedures (actionable step-by-step) and link each procedure to the relevant catalogue entries and system security plan sections | Security Engineer | Enterprise | 40h | £— |
| Exception management with expiry: process, templates, governance workflow, and linkage to baseline generation and system security plan updates (including compensating measures) | Compliance Manager | Enterprise | 32h | £— |
| Evidence verification and traceability pack: produce auditable evidence mapping (catalogue requirement → baseline → deployed configuration → compliance report) and run at least one end-to-end pilot for a representative category | Quality Assurance Lead | Enterprise | 40h | £— |

**Total Estimated Effort:** 328h  
**Total Estimated Cost:** £18,000

###### Actions Required for Compliance

- [ ] Create an EMSEC/TEMPEST control catalogue that links each information category to the required protections for the system components, communications, and networks.
- [ ] Set up a process that links each category to its baseline, so the system automatically produces configuration baseline settings for each category and the corresponding sections in the system security plan.
- [ ] Build baseline security checks into infrastructure and application configuration standards, and include them in continuous integration and continuous delivery (CI/CD) release checks.
- [ ] Set up automated checks to confirm that the components you deploy, their communication settings, and their network settings match the agreed baseline settings for each category.
- [ ] Publish and link procedures that are aligned with TEMPEST requirements for controlling information leakage and emissions, and make them available as clear, step-by-step instructions for the relevant change and handling activities.
- [ ] Set up an exception process that includes offsetting controls and clear expiry and review dates, and make sure any approved exceptions are included in the automatically produced baseline documents and in the security plan content.
- [ ] Collect and store evidence that can be audited, showing how each information category’s catalogue requirements are linked to the deployed configuration and the compliance reports.


---

### PE-20 — Asset Monitoring and Tracking (Control)

This requirement is about making sure important items are not lost or put in the wrong place by using global positioning system (GPS) and radio-frequency identification (RFID) tracking. The system must automatically alert staff when tracked assets move into or out of agreed controlled areas. Without this, classified and confidential equipment, key information technology (IT) and operational technology (OT) hardware, and critical vehicles or equipment could be misplaced, accessed in unauthorised areas, or moved without anyone noticing—creating serious safety, compliance, and operational risks.

To meet this expectation, the organisation must track and monitor the specified assets while they are inside Department of Defense (DoD) controlled facilities, secure rooms, and OT production floors that have access control. It must also set up the system so that entry and exit events trigger alerts. The organisation must keep written procedures, records of the system and its configuration, and an up-to-date list of which assets are being tracked, and it must keep records of tracking events.

The organisation must document this capability in its security planning, produce a privacy plan for any impacts on personal privacy, and involve legal counsel where needed so privacy concerns are properly addressed.

##### GPS/RFID geofenced asset tracking with privacy-legal governance

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Establish authoritative asset tracking scope: create/maintain asset register for pe-20_odp.02 including GPS/RFID identifier mapping, ownership, and tracking mechanism assignment | Compliance Manager | Enterprise | 24h | — |
| Design and implement geofenced controlled areas: model pe-20_odp.03 as named geofences/zones; configure “inside/outside” semantics and validate boundary logic | System Design Authority | Enterprise | 32h | — |
| Deploy tracking platform configuration: configure ingestion of GPS/RFID events, normalise asset IDs, and implement geofence entry/exit event generation (asset ID, zone, timestamp, event type) | Platform Engineer | Enterprise | 40h | £12,000 |
| Integrate alerting and operational workflow: route entry/exit alerts to SOC/Operations; implement triage workflow hooks and generate closure evidence (ticket IDs, timestamps, operator identity) | Service Delivery Manager | Enterprise | 24h | £3,000 |
| Define and document operating procedures + evidence: commissioning/replacement lifecycle for tags/devices, alert triage/closure procedures, and reference the capability in system security planning artefacts | Security Engineer | Enterprise | 28h | — |
| Privacy and legal governance: complete privacy impact assessment/plan; run legal counsel and senior privacy official review/approval; document mitigations and residual risk | Data Protection Officer | Enterprise | 40h | £8,000 |
| Implement retention, access control, and auditability for tracking records: enforce RBAC/least privilege for viewing/export; configure retention schedule and audit logs for authorised access | Operations Lead | Enterprise | 32h | £2,500 |
| Execute validation and acceptance testing: test assets across zones to prove correct inside/outside detection; verify alert correctness and evidence capture; produce acceptance report | Quality Assurance Lead | Enterprise | 24h | — |

**Total Estimated Effort:** 264h  
**Total Estimated Cost:** £25,500

###### Actions Required for Compliance

- [ ] Create and keep an accurate, official inventory of the defined assets, and link each asset to its GPS (global positioning system) or RFID (radio-frequency identification) identifier.
- [ ] Set up geofences for each defined controlled area and check that the boundary locations are accurate using test assets.
- [ ] Set up the tracking system to record and time-stamp entry and exit events whenever a device moves into or out of a geofence.
- [ ] Build alert handling into the organisation’s day-to-day operations (for example, the ticketing process and the security operations centre) and require records showing that each alert has been reviewed (triaged) and either resolved or closed.
- [ ] Document the procedures for commissioning (setting up), replacing, decommissioning (retiring), and handling alerts for tags and devices, and reference this capability in the system security plan.
- [ ] Complete a privacy plan or assessment for asset location technologies, and obtain documented input from legal counsel and the senior privacy officer.
- [ ] Apply role-based access control (RBAC) to tracking records and set retention rules so location and movement event history can be audited.


---

### PE-21 — Electromagnetic Pulse Protection (Control)

This requirement is about protecting your most important equipment from very strong bursts of electromagnetic energy that could disrupt or permanently damage electronic systems. Without the right protection, a sudden electromagnetic pulse could switch off systems that operate continuously, interfere with equipment used to control operations, and lead to expensive downtime or unsafe working.

To meet this expectation, the organisation must:
- identify all on-site information systems and operational control components that support 24/7 operations, and
- apply the correct protective measures at the specific sites where the equipment is installed or connected.

The protective measures may include:
- shielding,
- surge protection for power and network inputs,
- earth grounding, and
- ferro-resonant transformers where they are applicable.

The organisation must document this approach in its physical and environmental protection procedures, keep clear records of what is installed and where, include the measures in each system’s security planning documents, and assign named responsibilities to the people who oversee physical protection, system build or integration, and ongoing oversight—supported by evidence that the protections are installed and maintained over time.

##### EMP protection standard and location register for 24x7 IT/OT

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Draft EMP Protection Standard covering minimum shielding, SPD requirements (power and relevant signal/network interfaces), ferro-resonant transformer decision criteria (where applicable), and earth grounding/bonding rules | Cyber Security Lead | Enterprise | 24h | — |
| Define engineering installation rules and acceptance criteria (bonding/termination practices, enclosure requirements, SPD selection/placement principles, grounding verification approach) | System Design Authority | Enterprise | 16h | — |
| Create EMP Protection Location Register data model and template (site → building → room → rack/cabinet → power distribution point → interface type) and establish governance for updates | Compliance Manager | Enterprise | 16h | — |
| Populate the EMP Protection Location Register for all on-prem information systems and OT control components supporting 24x7 operations (including identification of in-scope racks/cabinets and demarcation points) | Infrastructure Lead | Department | 40h | — |
| Update system security planning documentation templates and guidance so in-scope systems must reference the EMP Protection Standard and the exact register entries | Information Security / GRC Lead | Enterprise | 16h | — |
| Implement change/approval workflow enforcement (checklists, required sign-offs, and gating rules for installation/relocation and power/network demarcation changes) with audit-ready evidence capture | Project Manager | Enterprise | 24h | — |
| Assign named responsibilities and operating cadence (RACI, ownership for standard/register/verification, periodic review triggers, and escalation paths) | Service Delivery Manager | Enterprise | 8h | — |

**Total Estimated Effort:** 144h  
**Total Estimated Cost:** £0

###### Actions Required for Compliance

- [ ] Define and publish an EMP (electromagnetic pulse) protection standard covering shielding, surge suppressors, ferro-resonant transformers (where applicable), and earth grounding.
- [ ] Create an EMP (Emergency Management Plan) Protection Location Register that maps each in-scope system or component to its exact physical installation and connection points.
- [ ] Update each in-scope system security plan to point to the EMP Standard clauses and the matching entries in the Location Register.
- [ ] Put in place a change-approval step that requires sign-off from the EMP (electromagnetic pulse) protection team before any installations, relocations, or power and network boundary (demarcation) changes are carried out.
- [ ] Assign named responsibilities for maintaining the EMP Standard, maintaining the Location Register, and ensuring the system security plan is linked correctly.
- [ ] Collect and keep audit evidence for all in-scope systems, including standard version records, register entries, and references to the security plan.


---

### PE-22 — Component Marking (Control)

This requirement is about making sure that every piece of equipment that could handle sensitive information is clearly and visibly labelled with the level of sensitivity it is allowed to handle. Without this, devices such as laptops, phones, printers, monitors, or scanners could be used with the wrong type of information. That increases the risk that confidential or secret material is mishandled, sent to the wrong place, or accessed by people who should not have it.

To meet this requirement, the organisation must:
- identify all hardware connected to systems that process or store **Confidential** or **Secret** information; and
- physically mark each item with clear, easy-to-read labels stating the permitted sensitivity level for processing, storing, and sending.

The labels must:
- use the organisation’s approved wording;
- be based on documented information categories;
- be included in system planning; and
- be supported by written procedures, an up-to-date device inventory, and named responsibilities.

Labels must also be checked regularly and kept readable over time.

##### Physical marking of Confidential/Secret hardware components

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Draft and approve the controlled “Physical Component Security Label Standard” (wording, label format, placement rules by device type, permitted levels, exceptions, and change control triggers) | Compliance Manager | Enterprise | 24h | — |
| Define the mapping method from system security plan permitted impact/classification level to the required physical label text (including handling for Confidential vs Secret and any organisation-specific equivalents) | Data Protection Officer | Enterprise | 16h | — |
| Review and update the authoritative hardware asset inventory/CMDB schema and fields to support marking decisions (device type, connected/authorised systems, permitted impact/classification level, environment, and evidence references) | Platform Engineer | Enterprise | 20h | — |
| Perform inventory reconciliation and identify all hardware components requiring marking (including edge cases: shared devices, admin consoles, maintenance ports, peripherals, and redeployed assets) | Operations Lead | Department | 32h | — |
| Create and implement the controlled operational workflow/work orders for marking (asset add/redeploy/reclassify triggers, approval steps, SLA/change window, and escalation path) | Project Manager | Enterprise | 18h | — |
| Execute physical marking and quality checks for identified assets (apply labels, verify legibility/placement, record label text/level, and capture photo evidence per asset or sampling rule) | Service Delivery Manager | Department | 40h | £2,000 |
| Establish periodic label readability verification cadence and refurbishment/replace process (including audit sampling approach and evidence retention requirements) | Security Engineer | Enterprise | 16h | — |

**Total Estimated Effort:** 166h  
**Total Estimated Cost:** £2,000

###### Actions Required for Compliance

- [ ] Create and publish an approved, easy-to-read label standard that defines the allowed wording, layout, and placement rules for device types and their impact or classification.
- [ ] Update the authoritative asset inventory and configuration management database (CMDB) to record, for each hardware component, (1) which connected system(s) it is linked to and (2) the permitted impact or classification level.
- [ ] Identify every asset that is connected to, or authorised to connect to, Confidential or Secret systems, and flag the ones that must be marked with the correct classification.
- [ ] Set up a controlled work-order process that automatically applies physical labels when an asset is added or redeployed, and when the system is reclassified.
- [ ] Label each identified hardware component and carry out a physical quality check to confirm the label text is correct and clearly readable.
- [ ] Keep audit evidence for each asset (for example, at photo and label level), and carry out regular checks that labels are still readable during maintenance or refurbishment.


---

### PE-23 — Facility Location (Control)

This requirement is about making sure your organisation selects and records the exact location where a system will be housed, with a clear understanding of what could physically disrupt it. If you do not take account of hazards such as floods, fires, severe storms, earthquakes, terrorism, vandalism, and unusual electrical or electromagnetic interference, the system could be damaged, shut down, or become unreliable when you need it most.

To meet this expectation, the organisation must plan and document the facility location (and, where relevant, where within the building the system will be placed). This should be done by assessing the physical and environmental risks for that specific site, including risks related to electrical and electromagnetic interference. For systems that are already in place, the organisation must review the same hazards and ensure they are included in its overall risk management approach.

The organisation must also document how identified risks will be reduced, ensure contingency plans take account of hazards at the facility level, and record the location assumptions and hazard considerations in the system’s own planning documents.

##### Hazard-assessed facility location decision pack for each system

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Produce standard “facility location decision pack” template (site ID/name, address or cloud region/tenant identifier, room/zone where applicable, system ID, dates, owners, evidence references, and controlled document metadata) | Compliance Manager | Enterprise | 16h | — |
| Define and publish mandatory hazard checklist for site-specific assessment, including electromagnetic hazards (EMP exposure; electrical/electromagnetic interference sources such as nearby high-voltage infrastructure, lightning/grounding conditions, generator switching transients, and nearby RF/industrial EMI) | Cyber Security Lead | Enterprise | 24h | — |
| Create assessment workflow and evidence requirements (site survey/engineering statements/environmental reports; how evidence is captured, versioned, and retained for audit) | Project Manager | Enterprise | 20h | — |
| For each new system deployment and major relocation: perform hazard assessment for the selected facility/site and complete the decision pack with recorded findings and supporting evidence | Security Engineer | Business Unit | 40h | — |
| For each decision pack: map hazard findings to risk treatment and contingency assumptions (mitigation actions with owner/target date/status; alternate site criteria; power restoration assumptions; incident triggers) and update associated risk records | Compliance Manager | Business Unit | 32h | — |
| Integrate decision pack into system security documentation (attach as annex or controlled reference from the System Security Plan; ensure traceability from location assumptions to security planning) | System Design Authority | Department | 24h | — |
| Establish periodic re-validation process for existing facilities (aligned to risk review cycle and upon facility change), including review cadence, change triggers, and propagation of updates to risk treatment, contingency planning, and security plan annexes | Operations Lead | Enterprise | 24h | — |

**Total Estimated Effort:** 200h  
**Total Estimated Cost:** £0

###### Actions Required for Compliance

- [ ] Create a controlled “facility location decision pack” template with required fields for site identity, room or zone (if used), assessor, date, and references to supporting evidence.
- [ ] Create a hazard checklist that clearly includes electromagnetic pulse (EMP) and electrical or electromagnetic interference sources, alongside other physical and environmental hazards.
- [ ] For every new system deployment or major relocation, carry out and record a site-specific hazard assessment, and keep the supporting evidence.
- [ ] For each hazard finding, record the planned risk-reduction actions in the documentation (including the responsible owner, the target date, and the current status). Then update the assumptions used in the contingency planning to reflect these actions.
- [ ] Attach the decision pack to the system security plan (or reference it there) as an auditable annex.
- [ ] Schedule regular re-checks for existing systems in line with the organisation’s risk review cycle, and update the decision pack, risk response plan, contingency planning, and references in the system security plan.

